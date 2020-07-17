$('#fight').on('click', function () {
    //Get our useful numbers
    let heroStr = Number($('#heroStr').val());
    let heroDef = Number($('#heroDef').val());
    let heroHP = Number($('#heroHP').val());
    let monsterStr = Number($('#monsterStr').val());
    let monsterDef = Number($('#monsterDef').val());
    let monsterHP = Number($('#monsterHP').val());

    //Do the fight math
    let heroDmg = heroStr - monsterDef;
    if (heroDmg < 1) {
        heroDmg = 1;
    }
    let newMonsterHP = monsterHP - heroDmg;
    $('#monsterCurrent').text(`${newMonsterHP}`);
    $('#monsterHP').val(newMonsterHP);
    if (newMonsterHP < 1) {
        $('#victoryControls').show();
        $('#fightControls').hide();
    }

    let monsterDmg = monsterStr - heroDef;
    if (monsterDmg < 1) {
        monsterDmg = 1;
    }
    let newHeroHP = heroHP - monsterDmg;
    if (newHeroHP < 1) {
        $('#defeatControls').show();
        $('#fightControls').hide();
    }
    makeSwal(heroDmg, monsterDmg);
    $('#heroCurrent').text(`${newHeroHP}`);
    $('#heroHP').val(newHeroHP);
    $('#hp').val(newHeroHP);
    $('#hpRemain').val(newHeroHP);

})

function makeSwal(hDam, mDam) {
    let timerInterval
    Swal.fire({
        title: 'Combat Happens!',
        html: 'You did ' + hDam + ' damage! <br />The monster did ' + mDam + ' damage <hr />I will close in <b></b> milliseconds.',
        timer: 2000,
        timerProgressBar: true,
        onBeforeOpen: () => {
            Swal.showLoading()
            timerInterval = setInterval(() => {
                const content = Swal.getContent()
                if (content) {
                    const b = content.querySelector('b')
                    if (b) {
                        b.textContent = Swal.getTimerLeft()
                    }
                }
            }, 100)
        },
        onClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            console.log('I was closed by the timer')
        }
    })
}