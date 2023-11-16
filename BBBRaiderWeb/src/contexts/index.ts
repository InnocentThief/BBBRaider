import { FetchContext } from './fetch'
import { RaidContext } from './raid'
import { ScheduleContext } from './schedule'

export interface ContextRoot {
  fetch: FetchContext
  raid: RaidContext
  schedule: ScheduleContext
}

const fetchContext = new FetchContext()
const raidContext = new RaidContext()
const scheduleContext = new ScheduleContext(fetchContext)

export const Context: ContextRoot = {
  fetch: fetchContext,
  raid: raidContext,
  schedule: scheduleContext,
}
