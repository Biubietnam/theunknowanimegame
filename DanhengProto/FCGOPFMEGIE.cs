using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000509 RID: 1289
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FCGOPFMEGIE : IMessage<FCGOPFMEGIE>, IMessage, IEquatable<FCGOPFMEGIE>, IDeepCloneable<FCGOPFMEGIE>, IBufferMessage
	{
		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x0009EE17 File Offset: 0x0009D017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FCGOPFMEGIE> Parser
		{
			get
			{
				return FCGOPFMEGIE._parser;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060039C3 RID: 14787 RVA: 0x0009EE1E File Offset: 0x0009D01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FCGOPFMEGIEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x0009EE30 File Offset: 0x0009D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FCGOPFMEGIE.Descriptor;
			}
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x0009EE37 File Offset: 0x0009D037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCGOPFMEGIE()
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0009EE60 File Offset: 0x0009D060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCGOPFMEGIE(FCGOPFMEGIE other) : this()
		{
			this.bAGMKDOHBOC_ = other.bAGMKDOHBOC_.Clone();
			this.nJEHGBGHCKG_ = other.nJEHGBGHCKG_.Clone();
			this.bHBPCDHJMND_ = other.bHBPCDHJMND_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0009EEB7 File Offset: 0x0009D0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FCGOPFMEGIE Clone()
		{
			return new FCGOPFMEGIE(this);
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0009EEBF File Offset: 0x0009D0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OKEDFCPCFJO> BAGMKDOHBOC
		{
			get
			{
				return this.bAGMKDOHBOC_;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x0009EEC7 File Offset: 0x0009D0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FKLCCJDPHEI> NJEHGBGHCKG
		{
			get
			{
				return this.nJEHGBGHCKG_;
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x0009EECF File Offset: 0x0009D0CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JDJHMJBKHEF> BHBPCDHJMND
		{
			get
			{
				return this.bHBPCDHJMND_;
			}
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x0009EED7 File Offset: 0x0009D0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FCGOPFMEGIE);
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x0009EEE8 File Offset: 0x0009D0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FCGOPFMEGIE other)
		{
			return other != null && (other == this || (this.bAGMKDOHBOC_.Equals(other.bAGMKDOHBOC_) && this.nJEHGBGHCKG_.Equals(other.nJEHGBGHCKG_) && this.bHBPCDHJMND_.Equals(other.bHBPCDHJMND_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x0009EF50 File Offset: 0x0009D150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bAGMKDOHBOC_.GetHashCode();
			num ^= this.nJEHGBGHCKG_.GetHashCode();
			num ^= this.bHBPCDHJMND_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0009EFA0 File Offset: 0x0009D1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x0009EFA8 File Offset: 0x0009D1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x0009EFB4 File Offset: 0x0009D1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bAGMKDOHBOC_.WriteTo(ref output, FCGOPFMEGIE._repeated_bAGMKDOHBOC_codec);
			this.nJEHGBGHCKG_.WriteTo(ref output, FCGOPFMEGIE._repeated_nJEHGBGHCKG_codec);
			this.bHBPCDHJMND_.WriteTo(ref output, FCGOPFMEGIE._repeated_bHBPCDHJMND_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x0009F008 File Offset: 0x0009D208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bAGMKDOHBOC_.CalculateSize(FCGOPFMEGIE._repeated_bAGMKDOHBOC_codec);
			num += this.nJEHGBGHCKG_.CalculateSize(FCGOPFMEGIE._repeated_nJEHGBGHCKG_codec);
			num += this.bHBPCDHJMND_.CalculateSize(FCGOPFMEGIE._repeated_bHBPCDHJMND_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x0009F068 File Offset: 0x0009D268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FCGOPFMEGIE other)
		{
			if (other == null)
			{
				return;
			}
			this.bAGMKDOHBOC_.Add(other.bAGMKDOHBOC_);
			this.nJEHGBGHCKG_.Add(other.nJEHGBGHCKG_);
			this.bHBPCDHJMND_.Add(other.bHBPCDHJMND_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x0009F0C3 File Offset: 0x0009D2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x0009F0CC File Offset: 0x0009D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.bHBPCDHJMND_.AddEntriesFrom(ref input, FCGOPFMEGIE._repeated_bHBPCDHJMND_codec);
						}
					}
					else
					{
						this.nJEHGBGHCKG_.AddEntriesFrom(ref input, FCGOPFMEGIE._repeated_nJEHGBGHCKG_codec);
					}
				}
				else
				{
					this.bAGMKDOHBOC_.AddEntriesFrom(ref input, FCGOPFMEGIE._repeated_bAGMKDOHBOC_codec);
				}
			}
		}

		// Token: 0x040016FE RID: 5886
		private static readonly MessageParser<FCGOPFMEGIE> _parser = new MessageParser<FCGOPFMEGIE>(() => new FCGOPFMEGIE());

		// Token: 0x040016FF RID: 5887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001700 RID: 5888
		public const int BAGMKDOHBOCFieldNumber = 1;

		// Token: 0x04001701 RID: 5889
		private static readonly FieldCodec<OKEDFCPCFJO> _repeated_bAGMKDOHBOC_codec = FieldCodec.ForMessage<OKEDFCPCFJO>(10U, OKEDFCPCFJO.Parser);

		// Token: 0x04001702 RID: 5890
		private readonly RepeatedField<OKEDFCPCFJO> bAGMKDOHBOC_ = new RepeatedField<OKEDFCPCFJO>();

		// Token: 0x04001703 RID: 5891
		public const int NJEHGBGHCKGFieldNumber = 2;

		// Token: 0x04001704 RID: 5892
		private static readonly FieldCodec<FKLCCJDPHEI> _repeated_nJEHGBGHCKG_codec = FieldCodec.ForMessage<FKLCCJDPHEI>(18U, FKLCCJDPHEI.Parser);

		// Token: 0x04001705 RID: 5893
		private readonly RepeatedField<FKLCCJDPHEI> nJEHGBGHCKG_ = new RepeatedField<FKLCCJDPHEI>();

		// Token: 0x04001706 RID: 5894
		public const int BHBPCDHJMNDFieldNumber = 3;

		// Token: 0x04001707 RID: 5895
		private static readonly FieldCodec<JDJHMJBKHEF> _repeated_bHBPCDHJMND_codec = FieldCodec.ForMessage<JDJHMJBKHEF>(26U, JDJHMJBKHEF.Parser);

		// Token: 0x04001708 RID: 5896
		private readonly RepeatedField<JDJHMJBKHEF> bHBPCDHJMND_ = new RepeatedField<JDJHMJBKHEF>();
	}
}
