import { RaidContext } from './raid'
import { ScheduleContext } from './schedule'

export interface ContextRoot {
  raid: RaidContext
  schedule: ScheduleContext
}

const raidContext = new RaidContext()
const scheduleContext = new ScheduleContext()

export const Context: ContextRoot = {
  raid: raidContext,
  schedule: scheduleContext,
}
