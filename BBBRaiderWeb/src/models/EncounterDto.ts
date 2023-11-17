import {
  logTypeMissmatch,
  parseArray,
  parseNumber,
  parseString,
} from '../helpers/model'
import { EncounterPositionDto } from './EncounterPositionDto'

export class EncounterDto {
  encounterKey: string = ''
  name: string = ''
  description: string = ''
  preparation: string = ''
  fight: string = ''
  danger: string = ''
  sortOrder: number = 0
  raidKey: string = ''
  positions: EncounterPositionDto[] = []

  static fromJSON(obj: any): EncounterDto {
    if (!obj) {
      logTypeMissmatch('EncounterDto', obj)
      return new EncounterDto()
    }

    return {
      encounterKey: parseString(obj.encounterKey),
      name: parseString(obj.name),
      description: parseString(obj.description),
      preparation: parseString(obj.preparation),
      fight: parseString(obj.fight),
      danger: parseString(obj.danger),
      sortOrder: parseNumber(obj.sortOrder),
      raidKey: parseString(obj.raidKey),
      positions: parseArray(obj.positions, EncounterPositionDto.fromJSON),
    }
  }
}
