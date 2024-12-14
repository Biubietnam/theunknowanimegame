using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200110F RID: 4367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetLanguageScRsp : IMessage<SetLanguageScRsp>, IMessage, IEquatable<SetLanguageScRsp>, IDeepCloneable<SetLanguageScRsp>, IBufferMessage
	{
		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600C2B6 RID: 49846 RVA: 0x0020ADC9 File Offset: 0x00208FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetLanguageScRsp> Parser
		{
			get
			{
				return SetLanguageScRsp._parser;
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x0020ADD0 File Offset: 0x00208FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetLanguageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600C2B8 RID: 49848 RVA: 0x0020ADE2 File Offset: 0x00208FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetLanguageScRsp.Descriptor;
			}
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x0020ADE9 File Offset: 0x00208FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageScRsp()
		{
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x0020ADF1 File Offset: 0x00208FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageScRsp(SetLanguageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x0020AE22 File Offset: 0x00209022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageScRsp Clone()
		{
			return new SetLanguageScRsp(this);
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600C2BC RID: 49852 RVA: 0x0020AE2A File Offset: 0x0020902A
		// (set) Token: 0x0600C2BD RID: 49853 RVA: 0x0020AE32 File Offset: 0x00209032
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

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600C2BE RID: 49854 RVA: 0x0020AE3B File Offset: 0x0020903B
		// (set) Token: 0x0600C2BF RID: 49855 RVA: 0x0020AE43 File Offset: 0x00209043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageType Language
		{
			get
			{
				return this.language_;
			}
			set
			{
				this.language_ = value;
			}
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x0020AE4C File Offset: 0x0020904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetLanguageScRsp);
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x0020AE5A File Offset: 0x0020905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetLanguageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x0020AE98 File Offset: 0x00209098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Language != LanguageType.LanguageNone)
			{
				num ^= this.Language.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x0020AEF6 File Offset: 0x002090F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x0020AEFE File Offset: 0x002090FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x0020AF08 File Offset: 0x00209108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != LanguageType.LanguageNone)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Language);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x0020AF64 File Offset: 0x00209164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Language != LanguageType.LanguageNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Language);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x0020AFBC File Offset: 0x002091BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetLanguageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Language != LanguageType.LanguageNone)
			{
				this.Language = other.Language;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2C8 RID: 49864 RVA: 0x0020B00C File Offset: 0x0020920C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x0020B018 File Offset: 0x00209218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Language = (LanguageType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004EBB RID: 20155
		private static readonly MessageParser<SetLanguageScRsp> _parser = new MessageParser<SetLanguageScRsp>(() => new SetLanguageScRsp());

		// Token: 0x04004EBC RID: 20156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EBD RID: 20157
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04004EBE RID: 20158
		private uint retcode_;

		// Token: 0x04004EBF RID: 20159
		public const int LanguageFieldNumber = 4;

		// Token: 0x04004EC0 RID: 20160
		private LanguageType language_;
	}
}
