import {
  logTypeMissmatch,
  parseArray,
  parseDate,
  parseNumber,
  parseString,
} from '../helpers/model'
import { ParticipantDto } from './ParticipantDto'
import { PlayerDto } from './PlayerDto'
import { RaidDto } from './RaidDto'

export class ScheduleDto {
  scheduleKey: string = ''
  date: string = ''
  // duration: number = null
  playerCount: number = 0
  raidLeaderPlayerKey: string = ''
  raidLeader?: PlayerDto
  raidKey: string = ''
  raid?: RaidDto
  participants: ParticipantDto[] = []

  static fromJSON(obj: any): ScheduleDto {
    if (!obj) {
      logTypeMissmatch(`ScheduleDto`, obj)
      return new ScheduleDto()
    }

    return {
      scheduleKey: parseString(obj.scheduleKey),
      date: parseDate(obj.date),
      // duration: parseNumber(obj.duration),
      playerCount: parseNumber(obj.playerCount),
      raidLeaderPlayerKey: parseString(obj.raidLeaderPlayerKey),
      raidLeader: PlayerDto.fromJSON(obj.raidLeader),
      raidKey: parseString(obj.raidKey),
      raid: RaidDto.fromJSON(obj.raid),
      participants: parseArray(obj.participants, ParticipantDto.fromJSON),
    }
  }
}
