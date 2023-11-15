import { logTypeMissmatch, parseNumber, parseString } from '../helpers/model'

export class EncounterPositionDto {
  encounterPositionKey: string = ''
  name: string = ''
  sortOrder: number = 0
  description: string = ''
  encounterKey: string = ''

  static fromJSON(obj: any): EncounterPositionDto {
    if (!obj) {
      logTypeMissmatch('EncounterPositionDto', obj)
      return new EncounterPositionDto()
    }

    return {
      encounterPositionKey: parseString(obj.encounterPositionKey),
      name: parseString(obj.name),
      sortOrder: parseNumber(obj.sortOrder),
      description: parseString(obj.description),
      encounterKey: parseString(obj.enconterKey),
    }
  }
}
