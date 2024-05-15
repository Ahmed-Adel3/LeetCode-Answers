
var findFarmland = function(land) {
    let output=[]
    let farmer = function(i,j,arr){
        if(i<0 || j<0 || i>land.length-1 || j>land[0].length-1 || land[i][j]!=1)return
        land[i][j]=0
        if(i<arr[0]){
            arr[0]=i
        }
        if(j<arr[1]){
            arr[1]=j
        }
        if(i>arr[2]){
            arr[2]=i
        }
        if(j>arr[3]){
            arr[3]=j
        }
        farmer(i+1,j,arr)
        farmer(i-1,j,arr)
        farmer(i,j+1,arr)
        farmer(i,j-1,arr)

    }
    for(let i=0;i<land.length;i++){
        for(let j=0;j<land[0].length;j++){
            if(land[i][j]==1){
                let arr=[i,j,i,j]
                farmer(i,j,arr)
                output.push(arr)
            }
        }
    }
    return output
};