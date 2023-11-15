import { logTypeMissmatch, parseArray, parseString } from '../helpers/model'
import { EncounterDto } from './EncounterDto'

export class RaidDto {
  raidKey: string = ''
  name: string = ''
  encounters: EncounterDto[] = []

  static fromJSON(obj: any): RaidDto {
    if (!obj) {
      logTypeMissmatch('RaidDto', obj)
      return new RaidDto()
    }

    return {
      raidKey: parseString(obj.raidKey),
      name: parseString(obj.name),
      encounters: parseArray(obj.encounters, EncounterDto.fromJSON),
    }
  }
}
