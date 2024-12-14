using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011BD RID: 4541
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartPunkLordRaidCsReq : IMessage<StartPunkLordRaidCsReq>, IMessage, IEquatable<StartPunkLordRaidCsReq>, IDeepCloneable<StartPunkLordRaidCsReq>, IBufferMessage
	{
		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x00220251 File Offset: 0x0021E451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartPunkLordRaidCsReq> Parser
		{
			get
			{
				return StartPunkLordRaidCsReq._parser;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600CAD4 RID: 51924 RVA: 0x00220258 File Offset: 0x0021E458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartPunkLordRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x0022026A File Offset: 0x0021E46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartPunkLordRaidCsReq.Descriptor;
			}
		}

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x00220271 File Offset: 0x0021E471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidCsReq()
		{
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x00220279 File Offset: 0x0021E479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidCsReq(StartPunkLordRaidCsReq other) : this()
		{
			this.monsterId_ = other.monsterId_;
			this.uid_ = other.uid_;
			this.kEPHAGKCAGK_ = other.kEPHAGKCAGK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x002202B6 File Offset: 0x0021E4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartPunkLordRaidCsReq Clone()
		{
			return new StartPunkLordRaidCsReq(this);
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600CAD9 RID: 51929 RVA: 0x002202BE File Offset: 0x0021E4BE
		// (set) Token: 0x0600CADA RID: 51930 RVA: 0x002202C6 File Offset: 0x0021E4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600CADB RID: 51931 RVA: 0x002202CF File Offset: 0x0021E4CF
		// (set) Token: 0x0600CADC RID: 51932 RVA: 0x002202D7 File Offset: 0x0021E4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600CADD RID: 51933 RVA: 0x002202E0 File Offset: 0x0021E4E0
		// (set) Token: 0x0600CADE RID: 51934 RVA: 0x002202E8 File Offset: 0x0021E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KEPHAGKCAGK
		{
			get
			{
				return this.kEPHAGKCAGK_;
			}
			set
			{
				this.kEPHAGKCAGK_ = value;
			}
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x002202F1 File Offset: 0x0021E4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartPunkLordRaidCsReq);
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x00220300 File Offset: 0x0021E500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartPunkLordRaidCsReq other)
		{
			return other != null && (other == this || (this.MonsterId == other.MonsterId && this.Uid == other.Uid && this.KEPHAGKCAGK == other.KEPHAGKCAGK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x0022035C File Offset: 0x0021E55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MonsterId != 0U)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.KEPHAGKCAGK)
			{
				num ^= this.KEPHAGKCAGK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x002203CD File Offset: 0x0021E5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x002203D5 File Offset: 0x0021E5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x002203E0 File Offset: 0x0021E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KEPHAGKCAGK)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.KEPHAGKCAGK);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Uid);
			}
			if (this.MonsterId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x00220458 File Offset: 0x0021E658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MonsterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterId);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.KEPHAGKCAGK)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x002204BC File Offset: 0x0021E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartPunkLordRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MonsterId != 0U)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.KEPHAGKCAGK)
			{
				this.KEPHAGKCAGK = other.KEPHAGKCAGK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x00220520 File Offset: 0x0021E720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x0022052C File Offset: 0x0021E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MonsterId = input.ReadUInt32();
						}
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.KEPHAGKCAGK = input.ReadBool();
				}
			}
		}

		// Token: 0x040051C9 RID: 20937
		private static readonly MessageParser<StartPunkLordRaidCsReq> _parser = new MessageParser<StartPunkLordRaidCsReq>(() => new StartPunkLordRaidCsReq());

		// Token: 0x040051CA RID: 20938
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051CB RID: 20939
		public const int MonsterIdFieldNumber = 12;

		// Token: 0x040051CC RID: 20940
		private uint monsterId_;

		// Token: 0x040051CD RID: 20941
		public const int UidFieldNumber = 8;

		// Token: 0x040051CE RID: 20942
		private uint uid_;

		// Token: 0x040051CF RID: 20943
		public const int KEPHAGKCAGKFieldNumber = 6;

		// Token: 0x040051D0 RID: 20944
		private bool kEPHAGKCAGK_;
	}
}
