using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200121D RID: 4637
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingActionTurnSettleScNotify : IMessage<SwordTrainingActionTurnSettleScNotify>, IMessage, IEquatable<SwordTrainingActionTurnSettleScNotify>, IDeepCloneable<SwordTrainingActionTurnSettleScNotify>, IBufferMessage
	{
		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600CF42 RID: 53058 RVA: 0x0022B9C3 File Offset: 0x00229BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingActionTurnSettleScNotify> Parser
		{
			get
			{
				return SwordTrainingActionTurnSettleScNotify._parser;
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600CF43 RID: 53059 RVA: 0x0022B9CA File Offset: 0x00229BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingActionTurnSettleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600CF44 RID: 53060 RVA: 0x0022B9DC File Offset: 0x00229BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingActionTurnSettleScNotify.Descriptor;
			}
		}

		// Token: 0x0600CF45 RID: 53061 RVA: 0x0022B9E3 File Offset: 0x00229BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingActionTurnSettleScNotify()
		{
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x0022B9F6 File Offset: 0x00229BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingActionTurnSettleScNotify(SwordTrainingActionTurnSettleScNotify other) : this()
		{
			this.bJIPCDPLPAL_ = other.bJIPCDPLPAL_.Clone();
			this.aFIHNCKKKPB_ = other.aFIHNCKKKPB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x0022BA2C File Offset: 0x00229C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingActionTurnSettleScNotify Clone()
		{
			return new SwordTrainingActionTurnSettleScNotify(this);
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600CF48 RID: 53064 RVA: 0x0022BA34 File Offset: 0x00229C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NOJPFGOHGKE> BJIPCDPLPAL
		{
			get
			{
				return this.bJIPCDPLPAL_;
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600CF49 RID: 53065 RVA: 0x0022BA3C File Offset: 0x00229C3C
		// (set) Token: 0x0600CF4A RID: 53066 RVA: 0x0022BA44 File Offset: 0x00229C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AFIHNCKKKPB
		{
			get
			{
				return this.aFIHNCKKKPB_;
			}
			set
			{
				this.aFIHNCKKKPB_ = value;
			}
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x0022BA4D File Offset: 0x00229C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingActionTurnSettleScNotify);
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x0022BA5C File Offset: 0x00229C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingActionTurnSettleScNotify other)
		{
			return other != null && (other == this || (this.bJIPCDPLPAL_.Equals(other.bJIPCDPLPAL_) && this.AFIHNCKKKPB == other.AFIHNCKKKPB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x0022BAAC File Offset: 0x00229CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bJIPCDPLPAL_.GetHashCode();
			if (this.AFIHNCKKKPB != 0U)
			{
				num ^= this.AFIHNCKKKPB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x0022BAF9 File Offset: 0x00229CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x0022BB01 File Offset: 0x00229D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x0022BB0C File Offset: 0x00229D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AFIHNCKKKPB != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AFIHNCKKKPB);
			}
			this.bJIPCDPLPAL_.WriteTo(ref output, SwordTrainingActionTurnSettleScNotify._repeated_bJIPCDPLPAL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x0022BB5C File Offset: 0x00229D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bJIPCDPLPAL_.CalculateSize(SwordTrainingActionTurnSettleScNotify._repeated_bJIPCDPLPAL_codec);
			if (this.AFIHNCKKKPB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AFIHNCKKKPB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x0022BBB0 File Offset: 0x00229DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingActionTurnSettleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bJIPCDPLPAL_.Add(other.bJIPCDPLPAL_);
			if (other.AFIHNCKKKPB != 0U)
			{
				this.AFIHNCKKKPB = other.AFIHNCKKKPB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x0022BBFD File Offset: 0x00229DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF54 RID: 53076 RVA: 0x0022BC08 File Offset: 0x00229E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bJIPCDPLPAL_.AddEntriesFrom(ref input, SwordTrainingActionTurnSettleScNotify._repeated_bJIPCDPLPAL_codec);
					}
				}
				else
				{
					this.AFIHNCKKKPB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005368 RID: 21352
		private static readonly MessageParser<SwordTrainingActionTurnSettleScNotify> _parser = new MessageParser<SwordTrainingActionTurnSettleScNotify>(() => new SwordTrainingActionTurnSettleScNotify());

		// Token: 0x04005369 RID: 21353
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400536A RID: 21354
		public const int BJIPCDPLPALFieldNumber = 14;

		// Token: 0x0400536B RID: 21355
		private static readonly FieldCodec<NOJPFGOHGKE> _repeated_bJIPCDPLPAL_codec = FieldCodec.ForMessage<NOJPFGOHGKE>(114U, NOJPFGOHGKE.Parser);

		// Token: 0x0400536C RID: 21356
		private readonly RepeatedField<NOJPFGOHGKE> bJIPCDPLPAL_ = new RepeatedField<NOJPFGOHGKE>();

		// Token: 0x0400536D RID: 21357
		public const int AFIHNCKKKPBFieldNumber = 10;

		// Token: 0x0400536E RID: 21358
		private uint aFIHNCKKKPB_;
	}
}
