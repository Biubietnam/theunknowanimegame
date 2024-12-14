using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000975 RID: 2421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JLENPNKJOJD : IMessage<JLENPNKJOJD>, IMessage, IEquatable<JLENPNKJOJD>, IDeepCloneable<JLENPNKJOJD>, IBufferMessage
	{
		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06006C3C RID: 27708 RVA: 0x00120F60 File Offset: 0x0011F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JLENPNKJOJD> Parser
		{
			get
			{
				return JLENPNKJOJD._parser;
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x00120F67 File Offset: 0x0011F167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JLENPNKJOJDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06006C3E RID: 27710 RVA: 0x00120F79 File Offset: 0x0011F179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JLENPNKJOJD.Descriptor;
			}
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x00120F80 File Offset: 0x0011F180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLENPNKJOJD()
		{
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x00120F88 File Offset: 0x0011F188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLENPNKJOJD(JLENPNKJOJD other) : this()
		{
			this.dialogueId_ = other.dialogueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x00120FAD File Offset: 0x0011F1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLENPNKJOJD Clone()
		{
			return new JLENPNKJOJD(this);
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x00120FB5 File Offset: 0x0011F1B5
		// (set) Token: 0x06006C43 RID: 27715 RVA: 0x00120FBD File Offset: 0x0011F1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x00120FC6 File Offset: 0x0011F1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JLENPNKJOJD);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x00120FD4 File Offset: 0x0011F1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JLENPNKJOJD other)
		{
			return other != null && (other == this || (this.DialogueId == other.DialogueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x00121004 File Offset: 0x0011F204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x00121043 File Offset: 0x0011F243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x0012104B File Offset: 0x0011F24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00121054 File Offset: 0x0011F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00121088 File Offset: 0x0011F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x001210C6 File Offset: 0x0011F2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JLENPNKJOJD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C4C RID: 27724 RVA: 0x001210F7 File Offset: 0x0011F2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x00121100 File Offset: 0x0011F300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002976 RID: 10614
		private static readonly MessageParser<JLENPNKJOJD> _parser = new MessageParser<JLENPNKJOJD>(() => new JLENPNKJOJD());

		// Token: 0x04002977 RID: 10615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002978 RID: 10616
		public const int DialogueIdFieldNumber = 1;

		// Token: 0x04002979 RID: 10617
		private uint dialogueId_;
	}
}
