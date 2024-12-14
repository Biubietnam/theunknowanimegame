using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200096B RID: 2411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JIIOHNDIHAM : IMessage<JIIOHNDIHAM>, IMessage, IEquatable<JIIOHNDIHAM>, IDeepCloneable<JIIOHNDIHAM>, IBufferMessage
	{
		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x0011F079 File Offset: 0x0011D279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JIIOHNDIHAM> Parser
		{
			get
			{
				return JIIOHNDIHAM._parser;
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x0011F080 File Offset: 0x0011D280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JIIOHNDIHAMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06006BAE RID: 27566 RVA: 0x0011F092 File Offset: 0x0011D292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JIIOHNDIHAM.Descriptor;
			}
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x0011F099 File Offset: 0x0011D299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JIIOHNDIHAM()
		{
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x0011F0AC File Offset: 0x0011D2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JIIOHNDIHAM(JIIOHNDIHAM other) : this()
		{
			this.iEEBMHPFDLC_ = other.iEEBMHPFDLC_;
			this.lJMHFFIONBI_ = other.lJMHFFIONBI_;
			this.eMIABAPFDEK_ = other.eMIABAPFDEK_.Clone();
			this.lONLLBIHMID_ = other.lONLLBIHMID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x0011F105 File Offset: 0x0011D305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JIIOHNDIHAM Clone()
		{
			return new JIIOHNDIHAM(this);
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06006BB2 RID: 27570 RVA: 0x0011F10D File Offset: 0x0011D30D
		// (set) Token: 0x06006BB3 RID: 27571 RVA: 0x0011F115 File Offset: 0x0011D315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IEEBMHPFDLC
		{
			get
			{
				return this.iEEBMHPFDLC_;
			}
			set
			{
				this.iEEBMHPFDLC_ = value;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x0011F11E File Offset: 0x0011D31E
		// (set) Token: 0x06006BB5 RID: 27573 RVA: 0x0011F126 File Offset: 0x0011D326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LJMHFFIONBI
		{
			get
			{
				return this.lJMHFFIONBI_;
			}
			set
			{
				this.lJMHFFIONBI_ = value;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06006BB6 RID: 27574 RVA: 0x0011F12F File Offset: 0x0011D32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EMIABAPFDEK
		{
			get
			{
				return this.eMIABAPFDEK_;
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x0011F137 File Offset: 0x0011D337
		// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x0011F13F File Offset: 0x0011D33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LONLLBIHMID
		{
			get
			{
				return this.lONLLBIHMID_;
			}
			set
			{
				this.lONLLBIHMID_ = value;
			}
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x0011F148 File Offset: 0x0011D348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JIIOHNDIHAM);
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x0011F158 File Offset: 0x0011D358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JIIOHNDIHAM other)
		{
			return other != null && (other == this || (this.IEEBMHPFDLC == other.IEEBMHPFDLC && this.LJMHFFIONBI == other.LJMHFFIONBI && this.eMIABAPFDEK_.Equals(other.eMIABAPFDEK_) && this.LONLLBIHMID == other.LONLLBIHMID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x0011F1C8 File Offset: 0x0011D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IEEBMHPFDLC != 0U)
			{
				num ^= this.IEEBMHPFDLC.GetHashCode();
			}
			if (this.LJMHFFIONBI)
			{
				num ^= this.LJMHFFIONBI.GetHashCode();
			}
			num ^= this.eMIABAPFDEK_.GetHashCode();
			if (this.LONLLBIHMID != 0U)
			{
				num ^= this.LONLLBIHMID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x0011F247 File Offset: 0x0011D447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x0011F24F File Offset: 0x0011D44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x0011F258 File Offset: 0x0011D458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LJMHFFIONBI)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.LJMHFFIONBI);
			}
			if (this.LONLLBIHMID != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.LONLLBIHMID);
			}
			if (this.IEEBMHPFDLC != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.IEEBMHPFDLC);
			}
			this.eMIABAPFDEK_.WriteTo(ref output, JIIOHNDIHAM._repeated_eMIABAPFDEK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x0011F2E0 File Offset: 0x0011D4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IEEBMHPFDLC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEEBMHPFDLC);
			}
			if (this.LJMHFFIONBI)
			{
				num += 2;
			}
			num += this.eMIABAPFDEK_.CalculateSize(JIIOHNDIHAM._repeated_eMIABAPFDEK_codec);
			if (this.LONLLBIHMID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LONLLBIHMID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x0011F358 File Offset: 0x0011D558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JIIOHNDIHAM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IEEBMHPFDLC != 0U)
			{
				this.IEEBMHPFDLC = other.IEEBMHPFDLC;
			}
			if (other.LJMHFFIONBI)
			{
				this.LJMHFFIONBI = other.LJMHFFIONBI;
			}
			this.eMIABAPFDEK_.Add(other.eMIABAPFDEK_);
			if (other.LONLLBIHMID != 0U)
			{
				this.LONLLBIHMID = other.LONLLBIHMID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x0011F3CD File Offset: 0x0011D5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x0011F3D8 File Offset: 0x0011D5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LJMHFFIONBI = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.LONLLBIHMID = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IEEBMHPFDLC = input.ReadUInt32();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.eMIABAPFDEK_.AddEntriesFrom(ref input, JIIOHNDIHAM._repeated_eMIABAPFDEK_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002934 RID: 10548
		private static readonly MessageParser<JIIOHNDIHAM> _parser = new MessageParser<JIIOHNDIHAM>(() => new JIIOHNDIHAM());

		// Token: 0x04002935 RID: 10549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002936 RID: 10550
		public const int IEEBMHPFDLCFieldNumber = 4;

		// Token: 0x04002937 RID: 10551
		private uint iEEBMHPFDLC_;

		// Token: 0x04002938 RID: 10552
		public const int LJMHFFIONBIFieldNumber = 1;

		// Token: 0x04002939 RID: 10553
		private bool lJMHFFIONBI_;

		// Token: 0x0400293A RID: 10554
		public const int EMIABAPFDEKFieldNumber = 5;

		// Token: 0x0400293B RID: 10555
		private static readonly FieldCodec<uint> _repeated_eMIABAPFDEK_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x0400293C RID: 10556
		private readonly RepeatedField<uint> eMIABAPFDEK_ = new RepeatedField<uint>();

		// Token: 0x0400293D RID: 10557
		public const int LONLLBIHMIDFieldNumber = 2;

		// Token: 0x0400293E RID: 10558
		private uint lONLLBIHMID_;
	}
}
