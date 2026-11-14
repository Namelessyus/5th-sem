export const Test=()=>{
    const testjsonData ={
      
  userId: 1,
  id: 1,
  title: "sample title",
  body: "sample body"
    };

   const arrayJsonData=[
        {id:1, name:"Anushma", lastName:"Shakya"},
        {id:2, name:"Jane", lastName:"Smith"},
        {id:3, name:"Alice", lastName:"Johnson"},
        {id:4, name:"Bob", lastName:"Brown"}    
    ];

    return(
        <>
        <h1> My User Title is </h1>
        <p>
           {testjsonData.title}
        </p>

        <h2>All Users (with index)</h2>
        {arrayJsonData.map((item,index) => (
            <div key={item.id}>
           <p> {index+1}. {item?.name}
              </p>
           </div>
    ))}
 
    <h2>first 2 users(slice)</h2>
    {arrayJsonData.slice(0,2).map((item)=>(
        <div key={item.id}>
            <p>{item.name}</p>
            </div>
    ))}
        <h2>Filtered Users (id &gt;2)</h2>
        {arrayJsonData
        .filter((item)=> item.id > 2)
        .map((item)=>(
            <div key={item.id}>
                <p>{item.name}</p>
            </div>
    ))}
    </>
    );
}