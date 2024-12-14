using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000447 RID: 1095
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFeverTimeActivityStageCsReq : IMessage<EnterFeverTimeActivityStageCsReq>, IMessage, IEquatable<EnterFeverTimeActivityStageCsReq>, IDeepCloneable<EnterFeverTimeActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x00085923 File Offset: 0x00083B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFeverTimeActivityStageCsReq> Parser
		{
			get
			{
				return EnterFeverTimeActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0008592A File Offset: 0x00083B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFeverTimeActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0008593C File Offset: 0x00083B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFeverTimeActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00085943 File Offset: 0x00083B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageCsReq()
		{
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00085958 File Offset: 0x00083B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageCsReq(EnterFeverTimeActivityStageCsReq other) : this()
		{
			this.id_ = other.id_;
			this.aDNPPCILFMA_ = other.aDNPPCILFMA_;
			this.avatarList_ = other.avatarList_.Clone();
			this.bOOHBIJBBIA_ = other.bOOHBIJBBIA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x000859B1 File Offset: 0x00083BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFeverTimeActivityStageCsReq Clone()
		{
			return new EnterFeverTimeActivityStageCsReq(this);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000859B9 File Offset: 0x00083BB9
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x000859C1 File Offset: 0x00083BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000859CA File Offset: 0x00083BCA
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x000859D2 File Offset: 0x00083BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ADNPPCILFMA
		{
			get
			{
				return this.aDNPPCILFMA_;
			}
			set
			{
				this.aDNPPCILFMA_ = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000859DB File Offset: 0x00083BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MFDEGCNEJMO> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x000859E3 File Offset: 0x00083BE3
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x000859EB File Offset: 0x00083BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BOOHBIJBBIA
		{
			get
			{
				return this.bOOHBIJBBIA_;
			}
			set
			{
				this.bOOHBIJBBIA_ = value;
			}
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000859F4 File Offset: 0x00083BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFeverTimeActivityStageCsReq);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00085A04 File Offset: 0x00083C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFeverTimeActivityStageCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ADNPPCILFMA == other.ADNPPCILFMA && this.avatarList_.Equals(other.avatarList_) && this.BOOHBIJBBIA == other.BOOHBIJBBIA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00085A74 File Offset: 0x00083C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ADNPPCILFMA != 0U)
			{
				num ^= this.ADNPPCILFMA.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.BOOHBIJBBIA != 0U)
			{
				num ^= this.BOOHBIJBBIA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x00085AF3 File Offset: 0x00083CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00085AFB File Offset: 0x00083CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00085B04 File Offset: 0x00083D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, EnterFeverTimeActivityStageCsReq._repeated_avatarList_codec);
			if (this.Id != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Id);
			}
			if (this.ADNPPCILFMA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ADNPPCILFMA);
			}
			if (this.BOOHBIJBBIA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BOOHBIJBBIA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00085B8C File Offset: 0x00083D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.ADNPPCILFMA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ADNPPCILFMA);
			}
			num += this.avatarList_.CalculateSize(EnterFeverTimeActivityStageCsReq._repeated_avatarList_codec);
			if (this.BOOHBIJBBIA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BOOHBIJBBIA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00085C10 File Offset: 0x00083E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFeverTimeActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.ADNPPCILFMA != 0U)
			{
				this.ADNPPCILFMA = other.ADNPPCILFMA;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.BOOHBIJBBIA != 0U)
			{
				this.BOOHBIJBBIA = other.BOOHBIJBBIA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00085C85 File Offset: 0x00083E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00085C90 File Offset: 0x00083E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 26U)
					{
						this.avatarList_.AddEntriesFrom(ref input, EnterFeverTimeActivityStageCsReq._repeated_avatarList_codec);
						continue;
					}
					if (num == 64U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ADNPPCILFMA = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BOOHBIJBBIA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001358 RID: 4952
		private static readonly MessageParser<EnterFeverTimeActivityStageCsReq> _parser = new MessageParser<EnterFeverTimeActivityStageCsReq>(() => new EnterFeverTimeActivityStageCsReq());

		// Token: 0x04001359 RID: 4953
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400135A RID: 4954
		public const int IdFieldNumber = 8;

		// Token: 0x0400135B RID: 4955
		private uint id_;

		// Token: 0x0400135C RID: 4956
		public const int ADNPPCILFMAFieldNumber = 12;

		// Token: 0x0400135D RID: 4957
		private uint aDNPPCILFMA_;

		// Token: 0x0400135E RID: 4958
		public const int AvatarListFieldNumber = 3;

		// Token: 0x0400135F RID: 4959
		private static readonly FieldCodec<MFDEGCNEJMO> _repeated_avatarList_codec = FieldCodec.ForMessage<MFDEGCNEJMO>(26U, MFDEGCNEJMO.Parser);

		// Token: 0x04001360 RID: 4960
		private readonly RepeatedField<MFDEGCNEJMO> avatarList_ = new RepeatedField<MFDEGCNEJMO>();

		// Token: 0x04001361 RID: 4961
		public const int BOOHBIJBBIAFieldNumber = 13;

		// Token: 0x04001362 RID: 4962
		private uint bOOHBIJBBIA_;
	}
}
