const users =[{
id:1,
name:'bob',
},
{
id:1,
name:'sally',
},
{
id:1,
name:'bob',
age:30
}];

function arrangeBy(arr, criteria) {
  const newObj = arr.reduce(function (acc, currentValue) {
    if (!acc[currentValue[criteria]]) {
      acc[currentValue[criteria]] = [];
    }
    acc[currentValue[criteria]].push(currentValue);
    return acc;
  }, {});
  return newObj;
}

const grouped = arrangeBy(users, "name");
