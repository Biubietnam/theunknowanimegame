using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A9B RID: 2715
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchResultScNotify : IMessage<MatchResultScNotify>, IMessage, IEquatable<MatchResultScNotify>, IDeepCloneable<MatchResultScNotify>, IBufferMessage
	{
		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x0013EF15 File Offset: 0x0013D115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchResultScNotify> Parser
		{
			get
			{
				return MatchResultScNotify._parser;
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600784F RID: 30799 RVA: 0x0013EF1C File Offset: 0x0013D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchResultScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x0013EF2E File Offset: 0x0013D12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchResultScNotify.Descriptor;
			}
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0013EF35 File Offset: 0x0013D135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResultScNotify()
		{
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0013EF48 File Offset: 0x0013D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResultScNotify(MatchResultScNotify other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eBMOKPBKMMD_ = other.eBMOKPBKMMD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0013EF7E File Offset: 0x0013D17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResultScNotify Clone()
		{
			return new MatchResultScNotify(this);
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x0013EF86 File Offset: 0x0013D186
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x0013EF8E File Offset: 0x0013D18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x0013EF97 File Offset: 0x0013D197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CCHCPNLPBDK> EBMOKPBKMMD
		{
			get
			{
				return this.eBMOKPBKMMD_;
			}
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x0013EF9F File Offset: 0x0013D19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchResultScNotify);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0013EFB0 File Offset: 0x0013D1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchResultScNotify other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.eBMOKPBKMMD_.Equals(other.eBMOKPBKMMD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x0013F000 File Offset: 0x0013D200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.eBMOKPBKMMD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x0013F04D File Offset: 0x0013D24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x0013F055 File Offset: 0x0013D255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x0013F060 File Offset: 0x0013D260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.eBMOKPBKMMD_.WriteTo(ref output, MatchResultScNotify._repeated_eBMOKPBKMMD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x0013F0B0 File Offset: 0x0013D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.eBMOKPBKMMD_.CalculateSize(MatchResultScNotify._repeated_eBMOKPBKMMD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x0013F104 File Offset: 0x0013D304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchResultScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.eBMOKPBKMMD_.Add(other.eBMOKPBKMMD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x0013F151 File Offset: 0x0013D351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x0013F15C File Offset: 0x0013D35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.eBMOKPBKMMD_.AddEntriesFrom(ref input, MatchResultScNotify._repeated_eBMOKPBKMMD_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E33 RID: 11827
		private static readonly MessageParser<MatchResultScNotify> _parser = new MessageParser<MatchResultScNotify>(() => new MatchResultScNotify());

		// Token: 0x04002E34 RID: 11828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E35 RID: 11829
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002E36 RID: 11830
		private uint retcode_;

		// Token: 0x04002E37 RID: 11831
		public const int EBMOKPBKMMDFieldNumber = 13;

		// Token: 0x04002E38 RID: 11832
		private static readonly FieldCodec<CCHCPNLPBDK> _repeated_eBMOKPBKMMD_codec = FieldCodec.ForMessage<CCHCPNLPBDK>(106U, CCHCPNLPBDK.Parser);

		// Token: 0x04002E39 RID: 11833
		private readonly RepeatedField<CCHCPNLPBDK> eBMOKPBKMMD_ = new RepeatedField<CCHCPNLPBDK>();
	}
}
