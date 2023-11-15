import {
  logTypeMissmatch,
  parseArray,
  parseNumber,
  parseString,
} from '../helpers/model'
import { EncounterPositionDto } from './EncounterPositionDto'

export class EncounterDto {
  enconterKey: string = ''
  name: string = ''
  sortOrder: number = 0
  raidKey: string = ''
  positions: EncounterPositionDto[] = []

  static fromJSON(obj: any): EncounterDto {
    if (!obj) {
      logTypeMissmatch('EncounterDto', obj)
      return new EncounterDto()
    }

    return {
      enconterKey: parseString(obj.EncounterDto),
      name: parseString(obj.name),
      sortOrder: parseNumber(obj.sortOrder),
      raidKey: parseString(obj.raidKey),
      positions: parseArray(obj.positions, EncounterPositionDto.fromJSON),
    }
  }
}
