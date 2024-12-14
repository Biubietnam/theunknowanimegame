using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D9 RID: 5081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateFloorSavedValueNotify : IMessage<UpdateFloorSavedValueNotify>, IMessage, IEquatable<UpdateFloorSavedValueNotify>, IDeepCloneable<UpdateFloorSavedValueNotify>, IBufferMessage
	{
		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x0600E278 RID: 57976 RVA: 0x0025A420 File Offset: 0x00258620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateFloorSavedValueNotify> Parser
		{
			get
			{
				return UpdateFloorSavedValueNotify._parser;
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x0600E279 RID: 57977 RVA: 0x0025A427 File Offset: 0x00258627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateFloorSavedValueNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0600E27A RID: 57978 RVA: 0x0025A439 File Offset: 0x00258639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFloorSavedValueNotify.Descriptor;
			}
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x0025A440 File Offset: 0x00258640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFloorSavedValueNotify()
		{
		}

		// Token: 0x0600E27C RID: 57980 RVA: 0x0025A454 File Offset: 0x00258654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFloorSavedValueNotify(UpdateFloorSavedValueNotify other) : this()
		{
			this.floorId_ = other.floorId_;
			this.planeId_ = other.planeId_;
			this.savedValue_ = other.savedValue_.Clone();
			this.dimensionId_ = other.dimensionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x0025A4AD File Offset: 0x002586AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFloorSavedValueNotify Clone()
		{
			return new UpdateFloorSavedValueNotify(this);
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x0600E27E RID: 57982 RVA: 0x0025A4B5 File Offset: 0x002586B5
		// (set) Token: 0x0600E27F RID: 57983 RVA: 0x0025A4BD File Offset: 0x002586BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x0600E280 RID: 57984 RVA: 0x0025A4C6 File Offset: 0x002586C6
		// (set) Token: 0x0600E281 RID: 57985 RVA: 0x0025A4CE File Offset: 0x002586CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x0600E282 RID: 57986 RVA: 0x0025A4D7 File Offset: 0x002586D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> SavedValue
		{
			get
			{
				return this.savedValue_;
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x0600E283 RID: 57987 RVA: 0x0025A4DF File Offset: 0x002586DF
		// (set) Token: 0x0600E284 RID: 57988 RVA: 0x0025A4E7 File Offset: 0x002586E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DimensionId
		{
			get
			{
				return this.dimensionId_;
			}
			set
			{
				this.dimensionId_ = value;
			}
		}

		// Token: 0x0600E285 RID: 57989 RVA: 0x0025A4F0 File Offset: 0x002586F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFloorSavedValueNotify);
		}

		// Token: 0x0600E286 RID: 57990 RVA: 0x0025A500 File Offset: 0x00258700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFloorSavedValueNotify other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.PlaneId == other.PlaneId && this.SavedValue.Equals(other.SavedValue) && this.DimensionId == other.DimensionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E287 RID: 57991 RVA: 0x0025A570 File Offset: 0x00258770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			num ^= this.SavedValue.GetHashCode();
			if (this.DimensionId != 0U)
			{
				num ^= this.DimensionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x0025A5EF File Offset: 0x002587EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E289 RID: 57993 RVA: 0x0025A5F7 File Offset: 0x002587F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x0025A600 File Offset: 0x00258800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.DimensionId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DimensionId);
			}
			this.savedValue_.WriteTo(ref output, UpdateFloorSavedValueNotify._map_savedValue_codec);
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.FloorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x0025A688 File Offset: 0x00258888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			num += this.savedValue_.CalculateSize(UpdateFloorSavedValueNotify._map_savedValue_codec);
			if (this.DimensionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DimensionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x0025A70C File Offset: 0x0025890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFloorSavedValueNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this.savedValue_.MergeFrom(other.savedValue_);
			if (other.DimensionId != 0U)
			{
				this.DimensionId = other.DimensionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E28D RID: 57997 RVA: 0x0025A781 File Offset: 0x00258981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x0025A78C File Offset: 0x0025898C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.DimensionId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.savedValue_.AddEntriesFrom(ref input, UpdateFloorSavedValueNotify._map_savedValue_codec);
						continue;
					}
					if (num == 120U)
					{
						this.FloorId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A0C RID: 23052
		private static readonly MessageParser<UpdateFloorSavedValueNotify> _parser = new MessageParser<UpdateFloorSavedValueNotify>(() => new UpdateFloorSavedValueNotify());

		// Token: 0x04005A0D RID: 23053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A0E RID: 23054
		public const int FloorIdFieldNumber = 15;

		// Token: 0x04005A0F RID: 23055
		private uint floorId_;

		// Token: 0x04005A10 RID: 23056
		public const int PlaneIdFieldNumber = 2;

		// Token: 0x04005A11 RID: 23057
		private uint planeId_;

		// Token: 0x04005A12 RID: 23058
		public const int SavedValueFieldNumber = 10;

		// Token: 0x04005A13 RID: 23059
		private static readonly MapField<string, int>.Codec _map_savedValue_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x04005A14 RID: 23060
		private readonly MapField<string, int> savedValue_ = new MapField<string, int>();

		// Token: 0x04005A15 RID: 23061
		public const int DimensionIdFieldNumber = 5;

		// Token: 0x04005A16 RID: 23062
		private uint dimensionId_;
	}
}
