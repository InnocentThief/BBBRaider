import { observer } from "mobx-react"
import { SyntheticEvent, useEffect } from "react"
import Vertical from "../layouts/Vertical"
import styled from "styled-components"
import { useParams } from "react-router-dom"
import { Context } from "../../contexts"
import { Callout, Card, ControlGroup, Divider, H3, H4, H5, Icon, Intent, Tag } from "@blueprintjs/core"
import { Select } from "@blueprintjs/select"
import { ItemRendererProps } from "@blueprintjs/select/lib/esm/common"

const Raid = () => {
    const { scheduleKey } = useParams()
    console.log(scheduleKey)

    const {
        schedule: { selectedSchedule, fetchSchedule }
    } = Context

    useEffect(() => {
        if (scheduleKey) fetchSchedule(scheduleKey)
    }, [scheduleKey, fetchSchedule])

    return <Container>
        <TitleCard>
            <H3>
                {selectedSchedule?.raid?.name}
            </H3>
            <SchedInfoGroup>
                <Icon icon='calendar' />
                <SchedInfoValue>{selectedSchedule?.date}</SchedInfoValue>
            </SchedInfoGroup>
            <SchedInfoGroup>
                <Icon icon='crown' />
                <SchedInfoValue>{selectedSchedule?.raidLeader?.name}</SchedInfoValue>
            </SchedInfoGroup>
            <SchedInfoGroup vertical={true} fill={false}>
                <PlayerTags>
                    {selectedSchedule?.participants.map(participant => (
                        <PlayerTag key={participant.participantKey}>
                            {participant.player?.name}
                        </PlayerTag>
                    ))}
                </PlayerTags>
            </SchedInfoGroup>
        </TitleCard>
        {selectedSchedule?.raid?.encounters.map(encounter => (
            <Encounter key={encounter.encounterKey}>
                <H4>
                    {encounter.name}
                </H4>
                {encounter.description && encounter.description !== 'null' &&
                    <EncounterCallout
                        title="Beschreibung">
                        {encounter.description}
                    </EncounterCallout>
                }
                {encounter.preparation && encounter.preparation !== 'null' &&
                    <EncounterCallout
                        intent={Intent.PRIMARY}
                        title="Vorbereitungsphase">
                        {encounter.preparation}
                    </EncounterCallout>
                }
                {encounter.fight && encounter.fight !== 'null' &&
                    <EncounterCallout
                        intent={Intent.WARNING}
                        title="Kampfphase">
                        {encounter.fight}
                    </EncounterCallout>
                }
                {encounter.danger && encounter.danger !== 'null' &&
                    <EncounterCallout
                        intent={Intent.DANGER}
                        title="Achtung">
                        {encounter.danger}
                    </EncounterCallout>
                }
                <Divider />
                <H5>Positionen</H5>
                <PositionList>
                    {encounter.positions.map(position => (
                        <EncounterParticipant>
                            <>{position.name}</>
                            <Select<string> items={[]} itemRenderer={function (item: string, itemProps: ItemRendererProps<HTMLLIElement>): JSX.Element | null {
                                throw new Error("Function not implemented.")
                            }} onItemSelect={function (item: string, event?: SyntheticEvent<HTMLElement, Event> | undefined): void {
                                throw new Error("Function not implemented.")
                            }}
                            />
                        </EncounterParticipant>
                    ))}
                </PositionList>


            </Encounter>
        ))}

    </Container>
}

const Container = styled(Vertical)`
    max-width: 1300px;
    margin: 15px;
    width: 100%;
`

const TitleCard = styled(Card)`
  background: #f6f7f9;
  .bp5-dark & {
    background: rgba(0,0,0,0.4);
  }
  display: grid;
  grid-template-columns: 1fr;
`

const SchedInfoGroup = styled(ControlGroup)`
    display: flex;
    margin-top: 6px;
`

const SchedInfoValue = styled.div`
`

const Encounter = styled(Card)`
  background: #f6f7f9;
  .bp5-dark & {
    background: rgba(0,0,0,0.2);
  }
  margin-top: 6px;
  display: grid;
  grid-template-columns: 1fr;
`

const PlayerTags = styled.div`
  display: flex;
  flex-wrap: wrap;
`

const PlayerTag = styled(Tag)`
 margin: 3px 3px;
`

const EncounterCallout = styled(Callout)`
margin-bottom: 3px;
`

const PositionList = styled.div`
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(400px, 1fr));
  gap: 6px;
`

const EncounterParticipant = styled.div`
    display: grid;
    grid-template-columns: 1fr 1fr;
`

export default observer(Raid)