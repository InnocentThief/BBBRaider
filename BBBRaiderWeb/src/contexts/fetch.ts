import * as toaster from './../helpers/toaster'
import { Settings } from 'luxon'

export class FetchContext {
  constructor() {
    Settings.defaultLocale = 'de'
  }

  fetch = async (
    url: string,
    init?: RequestInit | undefined,
    handleError = true
  ): Promise<Response> => {
    let headers: Headers
    if (init && init.headers) {
      headers = new Headers(init.headers)
    } else {
      headers = new Headers()
    }
    headers.append('content-type', 'application/json')
    headers.append('cache-control', 'no-cache')

    try {
      const response = await fetch(url, { ...init, headers })
      if (!response.ok && handleError) {
        toaster.error('Fehler bei der Server-Anfrage aufgetreten', {
          details: `${response.statusText} (${response.status}): ${
            init ? init.method : 'GET'
          } ${response.url}`,
        })
      }
      return response
    } catch (error) {
      toaster.error('Fehler bei der Server-Anfrage aufgetreten', {
        details: error,
      })
      throw error
    }
  }
}
