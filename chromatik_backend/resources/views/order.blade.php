<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Facture pour Pictura</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 800px;
            margin: auto;
            padding: 20px;
        }
        h1 {
            text-align: center;
        }
        table {
            width: 100%;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }
        th {
            background-color: #f2f2f2;
        }
        .total {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Facture pour Pictura</h1>
        <p>Date: {{ date('d.m.Y', strtotime($date)) }}</p>
        <p>Total: {{ $total_amount }} CHF</p>
 @php 
        use \App\Models\User;
        $user = User::find($command['user_id']);
    @endphp
    <p>Commande passée par : {{ $user->first_name . ' ' . $user->name  }}</p>
        <table>
            <thead>
                <tr>
                    <th>Type</th>
                    <th>Supply</th>
                    <th>Brand</th>
                    <th>Quantity</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
                @foreach($command['command_details'] as $cmd)
                    @php
                        $stock = \App\Models\Stock::find($cmd['stock_id']);
                    @endphp
                    <tr>
                        <td>{{ $stock->type }}</td>
                        <td>{{ $stock->supply }}</td>
                        <td>{{ $stock->brand }}</td>
                        <td>{{ $cmd['quantity'] }}</td>
                        <td>{{ $stock->price }}</td>
                    </tr>
                @endforeach
            </tbody>
        </table>
    </div>
</body>
</html>
