import { isObservableArray } from 'mobx'

// STRING
export function parseString(value: any): string
export function parseString(
  value: any,
  optional: 'optional'
): string | undefined
export function parseString(
  value: any,
  optional?: 'optional'
): string | undefined {
  if (optional && (typeof value === 'undefined' || value === null)) {
    return
  }
  if (typeof value !== 'string') {
    logTypeMissmatch('string', value)
  }
  return String(value)
}

// NUMBER
export function parseNumber(value: any): number
export function parseNumber(
  value: any,
  optional: 'optional'
): number | undefined
export function parseNumber(
  value: any,
  optional?: 'optional'
): number | undefined {
  if (optional && (typeof value === 'undefined' || value === null)) {
    return
  }
  if (typeof value !== 'number') {
    logTypeMissmatch('number', value)
  }
  return Number(value) || 0
}

// ARRAY
export function parseArray<T>(
  value: any,
  createFunction: (p: any) => T,
  init?: T[]
): T[] {
  if (init && (typeof value === 'undefined' || value === null)) {
    return init
  }

  // mobx4 limitation
  if (isObservableArray(value)) {
    value = value.slice()
  }
  if (!Array.isArray(value)) {
    logTypeMissmatch('array', value)
    return []
  }
  return value.map(createFunction)
}

export const logTypeMissmatch = (type: string, value: any): void => {
  // tslint:disable-next-line:no-console
  console.warn(
    `DTO type missmatch. Expected "${type}", but got "${typeof value}"`,
    value
  )
}
