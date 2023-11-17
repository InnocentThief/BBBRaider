import { logTypeMissmatch, parseString } from '../helpers/model'
import { PlayerDto } from './PlayerDto'

export class ParticipantDto {
  participantKey: string = ''
  playerKey: string = ''
  player?: PlayerDto
  scheduleKey: string = ''

  static fromJSON(obj: any): ParticipantDto {
    if (!obj) {
      logTypeMissmatch(`ParticipantDto`, obj)
      return new ParticipantDto()
    }

    return {
      participantKey: parseString(obj.participantKey),
      playerKey: parseString(obj.playerKey),
      player: PlayerDto.fromJSON(obj.player),
      scheduleKey: parseString(obj.scheduleKey),
    }
  }
}
