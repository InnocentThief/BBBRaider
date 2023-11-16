import { ActionProps, Intent, OverlayToaster, Position } from "@blueprintjs/core";
import * as React from 'react'
import styled from "styled-components";

const AppToaster = OverlayToaster.create({
    position: Position.BOTTOM,
    canEscapeKeyClear: false,
})

const DetailsToaster = OverlayToaster.create({
    position: Position.BOTTOM_RIGHT,
    canEscapeKeyClear: false
})

interface Config {
    details?: any
    toastId?: string | number
}

export const success = (message: string): void => {
    AppToaster.show({
        message: message,
        intent: Intent.SUCCESS,
        icon: 'tick-circle',
        timeout: 3000,
    })
}

export const error = (message: string | JSX.Element, config?: Config): void => {
    let actionProps: ActionProps | undefined
    if (config && config.details) {
        let details: React.ReactNode = config.details
        if (details instanceof Error) {
            details = details.message
        } else if (typeof details !== 'string' && !React.isValidElement(details)) {
            details = JSON.stringify(details)
        }
        actionProps = {
            text: 'Details anzeigen',
            onClick: () => {
                DetailsToaster.show({
                    message: <Wrap>{details}</Wrap>,
                    timeout: 0,
                    icon: 'info-sign',
                })
            },
        }
    }

    AppToaster.show(
        {
            message,
            intent: 'danger',
            icon: 'issue',
            timeout: 10000,
            action: actionProps,
        },
        config && config.toastId ? config.toastId.toString() : undefined
    )
}

export const dismiss = (toastId: string | number): void =>
    AppToaster.dismiss(toastId.toString())

export const dismissAll = (): void => {
    AppToaster.clear()
    DetailsToaster.clear()
}

const Wrap = styled.div`
  max-width: 400px;
  word-wrap: break-word;
`