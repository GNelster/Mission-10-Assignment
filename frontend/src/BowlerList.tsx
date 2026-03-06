import { useEffect, useState } from 'react';
import type { bowler } from './types/bowler';

function BowlerList() {
  const [bowlers, setBowlers] = useState<bowler[]>([]);

  // Makes an async call to get the data from the API, and read it into a JSON object to store the data.
  useEffect(() => {
    const fetchBowlers = async () => {
      const response = await fetch('https://localhost:5000/Bowler');
      const data = await response.json();
      setBowlers(data);
    };

    fetchBowlers(); // Calls the method that grabs the bowler data.
  }, []); // Empty array in case no data is pulled from the API.

  return (
    <>
      <table>
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerId}>
              <td>
                {' '}
                {/* Makes sure it displays middle names if present, won't if absent.*/}
                {b.bowlerMiddleInit
                  ? `${b.bowlerFirstName} ${b.bowlerMiddleInit}. ${b.bowlerLastName}`
                  : `${b.bowlerFirstName} ${b.bowlerLastName}`}
              </td>
              <td>{b.teamName}</td>
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
