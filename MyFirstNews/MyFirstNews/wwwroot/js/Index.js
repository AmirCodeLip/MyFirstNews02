
(function () {


    var bodyScop = undefined;

    async function GetNewsAjax(urlData = undefined) {

        let formData = new FormData();


        if (urlData) {
            if (urlData.tags)
                formData.append("tags", urlData.tags.toString());

        }

        let data = await fetch("Home/GetNews", {
            method: "POST",
            body: formData
        });
        let jsonData = await data.json();

        bodyScop.$apply(function () {

            bodyScop.newses = jsonData;
        });
    }
    this.onNgReady = function ($scop) {
        $scop.newses = [];
        $scop.tags = {};


        $scop.addTag = function (id) {
            $scop.tags[id] = {
                id: id
            }
        };
        $scop.tagChanged = () => {
            let importedTags = [];
            for (let i in $scop.tags) {
                if ($scop.tags[i].isChecked) {
                    importedTags.push($scop.tags[i].id);
                }
            }
            GetNewsAjax({
                tags: importedTags
            });

        };


        bodyScop = angular.element(document.body).scope();


        GetNewsAjax();

    }


}());