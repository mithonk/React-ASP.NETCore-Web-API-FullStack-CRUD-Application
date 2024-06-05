import axios from 'axios';
import { useEffect, useState } from 'react';

function StudentCrud() {
  const [id, setId] = useState('');
  const [name, setName] = useState('');
  const [course, setCourse] = useState('');
  const [students, setStudents] = useState('');

  useEffect(() => {
    (async () => await Load())();
  }, []);

  async function Load() {
    const result = await axios.get('');
    setStudents(result.data);
    console.log(result.data);
  }

  return (
    <div>
      <h1>Welcome to React</h1>
    </div>
  );
}

export default StudentCrud;
