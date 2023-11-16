import { logTypeMissmatch, parseString } from '../helpers/model'

export class PlayerDto {
  playerKey: string = ''
  name: string = ''

  static fromJSON(obj: any): PlayerDto {
    if (!obj) {
      logTypeMissmatch('PlayerDto', obj)
      return new PlayerDto()
    }

    return {
      playerKey: parseString(obj.playerKey),
      name: parseString(obj.name),
    }
  }
}
