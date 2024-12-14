using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200110D RID: 4365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetLanguageCsReq : IMessage<SetLanguageCsReq>, IMessage, IEquatable<SetLanguageCsReq>, IDeepCloneable<SetLanguageCsReq>, IBufferMessage
	{
		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x0020AB41 File Offset: 0x00208D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetLanguageCsReq> Parser
		{
			get
			{
				return SetLanguageCsReq._parser;
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600C2A2 RID: 49826 RVA: 0x0020AB48 File Offset: 0x00208D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetLanguageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x0020AB5A File Offset: 0x00208D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetLanguageCsReq.Descriptor;
			}
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x0020AB61 File Offset: 0x00208D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageCsReq()
		{
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x0020AB69 File Offset: 0x00208D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageCsReq(SetLanguageCsReq other) : this()
		{
			this.language_ = other.language_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x0020AB8E File Offset: 0x00208D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLanguageCsReq Clone()
		{
			return new SetLanguageCsReq(this);
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x0020AB96 File Offset: 0x00208D96
		// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x0020AB9E File Offset: 0x00208D9E
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

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x0020ABA7 File Offset: 0x00208DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetLanguageCsReq);
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x0020ABB5 File Offset: 0x00208DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetLanguageCsReq other)
		{
			return other != null && (other == this || (this.Language == other.Language && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x0020ABE4 File Offset: 0x00208DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C2AC RID: 49836 RVA: 0x0020AC29 File Offset: 0x00208E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x0020AC31 File Offset: 0x00208E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2AE RID: 49838 RVA: 0x0020AC3A File Offset: 0x00208E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Language != LanguageType.LanguageNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Language);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x0020AC6C File Offset: 0x00208E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x0020ACAA File Offset: 0x00208EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetLanguageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Language != LanguageType.LanguageNone)
			{
				this.Language = other.Language;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x0020ACDB File Offset: 0x00208EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2B2 RID: 49842 RVA: 0x0020ACE4 File Offset: 0x00208EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Language = (LanguageType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004EB6 RID: 20150
		private static readonly MessageParser<SetLanguageCsReq> _parser = new MessageParser<SetLanguageCsReq>(() => new SetLanguageCsReq());

		// Token: 0x04004EB7 RID: 20151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB8 RID: 20152
		public const int LanguageFieldNumber = 13;

		// Token: 0x04004EB9 RID: 20153
		private LanguageType language_;
	}
}
