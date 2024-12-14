using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C59 RID: 3161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OIOBNBAINGF : IMessage<OIOBNBAINGF>, IMessage, IEquatable<OIOBNBAINGF>, IDeepCloneable<OIOBNBAINGF>, IBufferMessage
	{
		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06008C66 RID: 35942 RVA: 0x0017339E File Offset: 0x0017159E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OIOBNBAINGF> Parser
		{
			get
			{
				return OIOBNBAINGF._parser;
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06008C67 RID: 35943 RVA: 0x001733A5 File Offset: 0x001715A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OIOBNBAINGFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06008C68 RID: 35944 RVA: 0x001733B7 File Offset: 0x001715B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OIOBNBAINGF.Descriptor;
			}
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x001733BE File Offset: 0x001715BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIOBNBAINGF()
		{
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x001733C6 File Offset: 0x001715C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIOBNBAINGF(OIOBNBAINGF other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x001733DF File Offset: 0x001715DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIOBNBAINGF Clone()
		{
			return new OIOBNBAINGF(this);
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x001733E7 File Offset: 0x001715E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OIOBNBAINGF);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x001733F5 File Offset: 0x001715F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OIOBNBAINGF other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x00173414 File Offset: 0x00171614
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

		// Token: 0x06008C6F RID: 35951 RVA: 0x0017343A File Offset: 0x0017163A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x00173442 File Offset: 0x00171642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x0017344B File Offset: 0x0017164B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x00173464 File Offset: 0x00171664
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

		// Token: 0x06008C73 RID: 35955 RVA: 0x0017348A File Offset: 0x0017168A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OIOBNBAINGF other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x001734A7 File Offset: 0x001716A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x001734B0 File Offset: 0x001716B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040035F0 RID: 13808
		private static readonly MessageParser<OIOBNBAINGF> _parser = new MessageParser<OIOBNBAINGF>(() => new OIOBNBAINGF());

		// Token: 0x040035F1 RID: 13809
		private UnknownFieldSet _unknownFields;
	}
}
