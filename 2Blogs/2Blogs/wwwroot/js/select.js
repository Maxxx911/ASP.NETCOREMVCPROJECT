var firstElement = document.getElementById('demo-1');
var choices1 = new Choices(firstElement, {
    delimiter: ',',
    editItems: true,
    maxItems: 5,
    removeButton: true
});
var secondElement = new Choices('#demo-2', { allowSearch: false }).setValue(['Set value 1', 'Set value 2']);
var choicesAjax = new Choices('#demo-2').ajax((callback) => {
    fetch('https://api.discogs.com/artists/391170/releases?token=QBRmstCkwXEvCjTclCpumbtNwvVkEzGAdELXyRyW')
        .then((response) => {
            response.json().then(function (data) {
                callback(data.releases, 'title', 'title');
            });
        })
        .catch((error) => {
            callback();
        });
})