fetch('https://dev-qj5ustyar7zvqbk.api.raw-labs.com/api/MyInfo')
    .then(response => response.json())
    .then(data => {
        const Introduction = data[0].info;
        const infoContainer1 = document.getElementById('info-container1');
        infoContainer1.innerHTML = Introduction;

        const Education = data[1].info;
        const infoContainer2 = document.getElementById('info-container2');
        infoContainer2.innerHTML = Education;

        const Hobbies = data[2].info;
        const infoContainer3 = document.getElementById('info-container3');
        infoContainer3.innerHTML = Hobbies;
    })
    .catch(error => {
        console.error('Error fetching data: ', error);
    });