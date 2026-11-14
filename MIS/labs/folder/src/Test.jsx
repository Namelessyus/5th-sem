const Test = () => {
  // Single JSON Object
  const testJsonData = {
    userId: 1,
    id: 1,
    title: "Sample Title",
    body: "Sample Body",
  };

  // Array of JSON Objects
  const arrayJsonData = [
    { id: 1, name: "Prajwal", lastName: "Maharjan" },
    { id: 2, name: "Ram", lastName: "Sharma" },
    { id: 3, name: "Sita", lastName: "Thapa" },
    { id: 4, name: "Hari", lastName: "Khadka" },
  ];

  // User Details
  const user = {
    name: "Prajwal Maharjan",
    age: 20,
    gender: "male",
    course: "BCA",
    semester: 5,
  };

  // Multiple Users
  const users = [
    {
      id: 1,
      name: "Prajwal Maharjan",
      age: 20,
      gender: "male",
      course: "BCA",
      semester: 5,
    },
    {
      id: 2,
      name: "Sita Karki",
      age: 19,
      gender: "male",
      course: "BCA",
      semester: 3,
    },
    {
      id: 3,
      name: "Ram Bahadur",
      age: 21,
      gender: "Male",
      course: "BIM",
      semester: 5,
    },
    {
      id: 4,
      name: "Nisha Sharma",
      age: 20,
      gender: "female",
      course: "BCA",
      semester: 4,
    },
  ];

  return (
    <div>
      <h1>Hello</h1>
      <h1>Hello</h1>
      <h2>Nice to meet you</h2>

      <h2>My User title is</h2>
      <p>{testJsonData.title}</p>

      <h2>All Users (with index)</h2>
      {arrayJsonData.map((item, index) => (
        <div key={item.id}>
          <p>
            {index + 1}. {item.name}
          </p>
        </div>
      ))}

      <h2>First 2 Users (slice)</h2>
      {arrayJsonData.slice(0, 2).map((item) => (
        <div key={item.id}>
          <p>{item.name}</p>
        </div>
      ))}

      <h2>Filtered Users (id &gt; 2)</h2>
      {arrayJsonData
        .filter((item) => item.id > 2)
        .map((item) => (
          <div key={item.id}>
            <p>{item.name}</p>
          </div>
        ))}

      <h2>User List</h2>
      <p>Name: {user.name}</p>
      <p>Age: {user.age}</p>
      <p>Gender: {user.gender}</p>
      <p>Course: {user.course}</p>
      <p>Semester: {user.semester}</p>

      <h2>User List</h2>
      {users.map((item) => (
        <div
          key={item.id}
          style={{ marginBottom: "15px", borderBottom: "1px solid #ccc" }}
        >
          <p>Name: {item.name}</p>
          <p>Age: {item.age}</p>
          <p>Gender: {item.gender}</p>
          <p>Course: {item.course}</p>
          <p>Semester: {item.semester}</p>
        </div>
      ))}
    </div>
  );
};

export default Test;