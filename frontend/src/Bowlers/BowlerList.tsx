import { useState } from "react";
import { Bowler } from "../Types/Bowler";

function BowlerList() {

    const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

    const fetchBowlerData = async () => {
        const rsp = await fetch('http://localhost:5263/api/bowler')
        const b = await rsp.json();
        setBowlerData(b);
    };

    fetchBowlerData();

    return(
    <>
        <div className="row">
            <h4 className="text-center">Bowling League Members</h4>
        </div>
        <table className="table table-bordered">
            <thead>
                <tr>
                    <th>Bowler Name</th>
                    <th>Team Name</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Zip</th>
                    <th>Phone Number</th>
                </tr>
            </thead>
            <tbody>
                {bowlerData.map((b)=> (
                    <tr key={b.bowlerId}>
                        <td>{b.bowlerFirstName} {b.bowlerMiddleInit} {b.bowlerLastName}</td>
                        <td>{b.bowlerAddress}</td>
                        <td>{b.bowlerCity}</td>
                        <td>{b.bowlerState}</td>
                        <td>{b.bowlerZip}</td>
                        <td>{b.bowlerPhoneNumber}</td>
                    </tr>
                ))}
            </tbody>
        </table>
    </>
    );
}

export default BowlerList;