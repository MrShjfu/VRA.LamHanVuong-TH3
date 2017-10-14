function result=BT8()
    imgTrainAll = loadMNISTImages('train-images.idx3-ubyte');
    lblTrainAll = loadMNISTLabels('train-labels.idx1-ubyte');
    imgTestAll = loadMNISTImages('t10k-images.idx3-ubyte');
    lblTestAll = loadMNISTLabels('t10k-labels.idx1-ubyte');
    fprintf('dang chay:\n');

    distance = {'cosine','euclidean','minkowski','cosine','jaccard','chebychev','seuclidean'};
    neighbor = [3 6 10 15 20];
    confusionmatrix = zeros(length(neighbor),size(distance,2),'uint32');
    a = 0;
    for i = 1: length(neighbor)
        for j = 1: length(distance)
            fprintf('so hinh da xong: %d\n', a);
            fprintf('NumNeighbors: %d | Distance: %s |', neighbor(i),distance{j});
            Mdl = fitcknn(imgTrainAll', lblTrainAll,'NumNeighbors',neighbor(i),'Distance',distance{j});
            lblPredictTest = predict(Mdl, imgTestAll');
            confusionmatrix(i,j)= sum(lblPredictTest==lblTestAll);
            a = a+1;
            fprintf('gia tri: %d\n', confusionmatrix(i,j));
        end
    end
    result=confusionmatrix;
    imshow(confusionmatrix, [], 'InitialMagnification', 10000);
end