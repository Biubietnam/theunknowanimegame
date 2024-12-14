using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000931 RID: 2353
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class INJNELLMNAC : IMessage<INJNELLMNAC>, IMessage, IEquatable<INJNELLMNAC>, IDeepCloneable<INJNELLMNAC>, IBufferMessage
	{
		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x001186E6 File Offset: 0x001168E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<INJNELLMNAC> Parser
		{
			get
			{
				return INJNELLMNAC._parser;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x001186ED File Offset: 0x001168ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return INJNELLMNACReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06006901 RID: 26881 RVA: 0x001186FF File Offset: 0x001168FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return INJNELLMNAC.Descriptor;
			}
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00118706 File Offset: 0x00116906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INJNELLMNAC()
		{
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x0011870E File Offset: 0x0011690E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INJNELLMNAC(INJNELLMNAC other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x00118727 File Offset: 0x00116927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public INJNELLMNAC Clone()
		{
			return new INJNELLMNAC(this);
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x0011872F File Offset: 0x0011692F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as INJNELLMNAC);
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x0011873D File Offset: 0x0011693D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(INJNELLMNAC other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x0011875C File Offset: 0x0011695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x00118782 File Offset: 0x00116982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x0011878A File Offset: 0x0011698A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x00118793 File Offset: 0x00116993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x001187AC File Offset: 0x001169AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x001187D2 File Offset: 0x001169D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(INJNELLMNAC other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x001187EF File Offset: 0x001169EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x001187F8 File Offset: 0x001169F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002847 RID: 10311
		private static readonly MessageParser<INJNELLMNAC> _parser = new MessageParser<INJNELLMNAC>(() => new INJNELLMNAC());

		// Token: 0x04002848 RID: 10312
		private UnknownFieldSet _unknownFields;
	}
}
