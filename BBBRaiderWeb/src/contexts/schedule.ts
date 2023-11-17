import { makeAutoObservable } from 'mobx'
import { ScheduleDto } from '../models/ScheduleDto'
import { FetchContext } from './fetch'
import { parseArray } from '../helpers/model'

export class ScheduleContext {
  loadedSchedules: ScheduleDto[] = []
  loadingSchedules = false
  selectedSchedule: ScheduleDto | null = null

  constructor(private fetch: FetchContext) {
    makeAutoObservable(this)
  }

  fetchSchedules = async () => {
    this.loadingSchedules = true
    this.selectedSchedule = null
    try {
      const response = await this.fetch.fetch(`/api/schedules`)
      const json = await response.json()
      this.loadedSchedules = parseArray(json, ScheduleDto.fromJSON)
    } catch (error) {
      this.loadedSchedules = []
    } finally {
      this.loadingSchedules = false
    }
  }

  fetchSchedule = async (scheduleKey: string) => {
    try {
      const response = await this.fetch.fetch(`/api/schedules/${scheduleKey}`)
      const json = await response.json()
      this.selectedSchedule = ScheduleDto.fromJSON(json)
    } catch (error) {
      return
    }
  }
}
