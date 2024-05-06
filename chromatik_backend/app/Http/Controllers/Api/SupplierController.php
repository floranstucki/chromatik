<?php 

namespace App\Http\Controllers\Api;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Http\Resources\SupplierResource;
use App\Http\Services\SupplierService;

class SupplierController extends Controller{
    public function __construct(private SupplierService $_supplierService){}

    public function index()
    {
        try {
            $suppliers = $this->_supplierService->getSuppliers();
            return SupplierResource::collection($suppliers);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function show(int $id)
    {
        try {
            $supplier =  $this->_supplierService->getSupplierById($id);
            return SupplierResource::collection($supplier);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function store(Request $request)
    {
        try {
            $supplier = $this->_supplierService->storeSupplier($request);
            return new SupplierResource($supplier);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function update(Request $request, int $id)
    {
        try {
            $supplier = $this->_supplierService->updateSupplier($request, $id);
            if ($supplier == null) {
                return response()->json(['message' => 'Supplier not found'], 404);
            }
            return response()->json(['message' => 'Supplier updated successfully', 'supplier' => $supplier]);
        } catch (\Exception $e) {
            throw $e;
        }
    }

    public function destroy(int $id)
    {
        try {
            $order = $this->_supplierService->deleteSupplier($id);
            return response()->json(['message' => 'Supplier deleted successfully']);
        } catch (\Exception $e) {
            throw $e;
        }
    }
}