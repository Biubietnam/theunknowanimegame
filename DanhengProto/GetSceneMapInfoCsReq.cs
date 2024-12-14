using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E5 RID: 2021
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSceneMapInfoCsReq : IMessage<GetSceneMapInfoCsReq>, IMessage, IEquatable<GetSceneMapInfoCsReq>, IDeepCloneable<GetSceneMapInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06005A24 RID: 23076 RVA: 0x000F05FF File Offset: 0x000EE7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSceneMapInfoCsReq> Parser
		{
			get
			{
				return GetSceneMapInfoCsReq._parser;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x000F0606 File Offset: 0x000EE806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSceneMapInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06005A26 RID: 23078 RVA: 0x000F0618 File Offset: 0x000EE818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSceneMapInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x000F061F File Offset: 0x000EE81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoCsReq()
		{
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x000F0634 File Offset: 0x000EE834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoCsReq(GetSceneMapInfoCsReq other) : this()
		{
			this.entryIdList_ = other.entryIdList_.Clone();
			this.entryStoryLineId_ = other.entryStoryLineId_;
			this.pNFPBICGDPC_ = other.pNFPBICGDPC_;
			this.contentId_ = other.contentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x000F068D File Offset: 0x000EE88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoCsReq Clone()
		{
			return new GetSceneMapInfoCsReq(this);
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x000F0695 File Offset: 0x000EE895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntryIdList
		{
			get
			{
				return this.entryIdList_;
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x000F069D File Offset: 0x000EE89D
		// (set) Token: 0x06005A2C RID: 23084 RVA: 0x000F06A5 File Offset: 0x000EE8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryStoryLineId
		{
			get
			{
				return this.entryStoryLineId_;
			}
			set
			{
				this.entryStoryLineId_ = value;
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06005A2D RID: 23085 RVA: 0x000F06AE File Offset: 0x000EE8AE
		// (set) Token: 0x06005A2E RID: 23086 RVA: 0x000F06B6 File Offset: 0x000EE8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PNFPBICGDPC
		{
			get
			{
				return this.pNFPBICGDPC_;
			}
			set
			{
				this.pNFPBICGDPC_ = value;
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x000F06BF File Offset: 0x000EE8BF
		// (set) Token: 0x06005A30 RID: 23088 RVA: 0x000F06C7 File Offset: 0x000EE8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x000F06D0 File Offset: 0x000EE8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSceneMapInfoCsReq);
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x000F06E0 File Offset: 0x000EE8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSceneMapInfoCsReq other)
		{
			return other != null && (other == this || (this.entryIdList_.Equals(other.entryIdList_) && this.EntryStoryLineId == other.EntryStoryLineId && this.PNFPBICGDPC == other.PNFPBICGDPC && this.ContentId == other.ContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x000F0750 File Offset: 0x000EE950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entryIdList_.GetHashCode();
			if (this.EntryStoryLineId != 0U)
			{
				num ^= this.EntryStoryLineId.GetHashCode();
			}
			if (this.PNFPBICGDPC)
			{
				num ^= this.PNFPBICGDPC.GetHashCode();
			}
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x000F07CF File Offset: 0x000EE9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x000F07D7 File Offset: 0x000EE9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x000F07E0 File Offset: 0x000EE9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntryStoryLineId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EntryStoryLineId);
			}
			if (this.PNFPBICGDPC)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.PNFPBICGDPC);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ContentId);
			}
			this.entryIdList_.WriteTo(ref output, GetSceneMapInfoCsReq._repeated_entryIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x000F0868 File Offset: 0x000EEA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entryIdList_.CalculateSize(GetSceneMapInfoCsReq._repeated_entryIdList_codec);
			if (this.EntryStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryStoryLineId);
			}
			if (this.PNFPBICGDPC)
			{
				num += 2;
			}
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x000F08E0 File Offset: 0x000EEAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSceneMapInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.entryIdList_.Add(other.entryIdList_);
			if (other.EntryStoryLineId != 0U)
			{
				this.EntryStoryLineId = other.EntryStoryLineId;
			}
			if (other.PNFPBICGDPC)
			{
				this.PNFPBICGDPC = other.PNFPBICGDPC;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x000F0955 File Offset: 0x000EEB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x000F0960 File Offset: 0x000EEB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num == 32U)
					{
						this.EntryStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PNFPBICGDPC = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.entryIdList_.AddEntriesFrom(ref input, GetSceneMapInfoCsReq._repeated_entryIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022FE RID: 8958
		private static readonly MessageParser<GetSceneMapInfoCsReq> _parser = new MessageParser<GetSceneMapInfoCsReq>(() => new GetSceneMapInfoCsReq());

		// Token: 0x040022FF RID: 8959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002300 RID: 8960
		public const int EntryIdListFieldNumber = 15;

		// Token: 0x04002301 RID: 8961
		private static readonly FieldCodec<uint> _repeated_entryIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04002302 RID: 8962
		private readonly RepeatedField<uint> entryIdList_ = new RepeatedField<uint>();

		// Token: 0x04002303 RID: 8963
		public const int EntryStoryLineIdFieldNumber = 4;

		// Token: 0x04002304 RID: 8964
		private uint entryStoryLineId_;

		// Token: 0x04002305 RID: 8965
		public const int PNFPBICGDPCFieldNumber = 13;

		// Token: 0x04002306 RID: 8966
		private bool pNFPBICGDPC_;

		// Token: 0x04002307 RID: 8967
		public const int ContentIdFieldNumber = 14;

		// Token: 0x04002308 RID: 8968
		private uint contentId_;
	}
}
