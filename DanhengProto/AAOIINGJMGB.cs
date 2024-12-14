using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000005 RID: 5
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AAOIINGJMGB : IMessage<AAOIINGJMGB>, IMessage, IEquatable<AAOIINGJMGB>, IDeepCloneable<AAOIINGJMGB>, IBufferMessage
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002159 File Offset: 0x00000359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AAOIINGJMGB> Parser
		{
			get
			{
				return AAOIINGJMGB._parser;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002160 File Offset: 0x00000360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AAOIINGJMGBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002172 File Offset: 0x00000372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AAOIINGJMGB.Descriptor;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002179 File Offset: 0x00000379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAOIINGJMGB()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000218C File Offset: 0x0000038C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAOIINGJMGB(AAOIINGJMGB other) : this()
		{
			this.jCDPAPLPOFC_ = other.jCDPAPLPOFC_;
			this.aHEMHHBFKLC_ = other.aHEMHHBFKLC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021C2 File Offset: 0x000003C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AAOIINGJMGB Clone()
		{
			return new AAOIINGJMGB(this);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000021CA File Offset: 0x000003CA
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000021D2 File Offset: 0x000003D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPOPEDEEAGB JCDPAPLPOFC
		{
			get
			{
				return this.jCDPAPLPOFC_;
			}
			set
			{
				this.jCDPAPLPOFC_ = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000021DB File Offset: 0x000003DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AHEMHHBFKLC
		{
			get
			{
				return this.aHEMHHBFKLC_;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021E3 File Offset: 0x000003E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AAOIINGJMGB);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021F4 File Offset: 0x000003F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AAOIINGJMGB other)
		{
			return other != null && (other == this || (this.JCDPAPLPOFC == other.JCDPAPLPOFC && this.aHEMHHBFKLC_.Equals(other.aHEMHHBFKLC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002244 File Offset: 0x00000444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JCDPAPLPOFC != KPOPEDEEAGB.MonopolySocialEventStatusNone)
			{
				num ^= this.JCDPAPLPOFC.GetHashCode();
			}
			num ^= this.aHEMHHBFKLC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002297 File Offset: 0x00000497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000229F File Offset: 0x0000049F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022A8 File Offset: 0x000004A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JCDPAPLPOFC != KPOPEDEEAGB.MonopolySocialEventStatusNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.JCDPAPLPOFC);
			}
			this.aHEMHHBFKLC_.WriteTo(ref output, AAOIINGJMGB._repeated_aHEMHHBFKLC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022F8 File Offset: 0x000004F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JCDPAPLPOFC != KPOPEDEEAGB.MonopolySocialEventStatusNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.JCDPAPLPOFC);
			}
			num += this.aHEMHHBFKLC_.CalculateSize(AAOIINGJMGB._repeated_aHEMHHBFKLC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000234C File Offset: 0x0000054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AAOIINGJMGB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JCDPAPLPOFC != KPOPEDEEAGB.MonopolySocialEventStatusNone)
			{
				this.JCDPAPLPOFC = other.JCDPAPLPOFC;
			}
			this.aHEMHHBFKLC_.Add(other.aHEMHHBFKLC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002399 File Offset: 0x00000599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023A4 File Offset: 0x000005A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aHEMHHBFKLC_.AddEntriesFrom(ref input, AAOIINGJMGB._repeated_aHEMHHBFKLC_codec);
					}
				}
				else
				{
					this.JCDPAPLPOFC = (KPOPEDEEAGB)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly MessageParser<AAOIINGJMGB> _parser = new MessageParser<AAOIINGJMGB>(() => new AAOIINGJMGB());

		// Token: 0x0400000A RID: 10
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400000B RID: 11
		public const int JCDPAPLPOFCFieldNumber = 6;

		// Token: 0x0400000C RID: 12
		private KPOPEDEEAGB jCDPAPLPOFC_;

		// Token: 0x0400000D RID: 13
		public const int AHEMHHBFKLCFieldNumber = 10;

		// Token: 0x0400000E RID: 14
		private static readonly FieldCodec<uint> _repeated_aHEMHHBFKLC_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x0400000F RID: 15
		private readonly RepeatedField<uint> aHEMHHBFKLC_ = new RepeatedField<uint>();
	}
}
