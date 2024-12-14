using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D5B RID: 3419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitWolfBroGameCsReq : IMessage<QuitWolfBroGameCsReq>, IMessage, IEquatable<QuitWolfBroGameCsReq>, IDeepCloneable<QuitWolfBroGameCsReq>, IBufferMessage
	{
		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x00196D08 File Offset: 0x00194F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitWolfBroGameCsReq> Parser
		{
			get
			{
				return QuitWolfBroGameCsReq._parser;
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x00196D0F File Offset: 0x00194F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitWolfBroGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x060098C6 RID: 39110 RVA: 0x00196D21 File Offset: 0x00194F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitWolfBroGameCsReq.Descriptor;
			}
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x00196D28 File Offset: 0x00194F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameCsReq()
		{
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00196D30 File Offset: 0x00194F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameCsReq(QuitWolfBroGameCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x00196D55 File Offset: 0x00194F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameCsReq Clone()
		{
			return new QuitWolfBroGameCsReq(this);
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x060098CA RID: 39114 RVA: 0x00196D5D File Offset: 0x00194F5D
		// (set) Token: 0x060098CB RID: 39115 RVA: 0x00196D65 File Offset: 0x00194F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x00196D6E File Offset: 0x00194F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitWolfBroGameCsReq);
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x00196D7C File Offset: 0x00194F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitWolfBroGameCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x00196DAC File Offset: 0x00194FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x00196DEB File Offset: 0x00194FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x00196DF3 File Offset: 0x00194FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x00196DFC File Offset: 0x00194FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x00196E30 File Offset: 0x00195030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x00196E6E File Offset: 0x0019506E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitWolfBroGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00196E9F File Offset: 0x0019509F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x00196EA8 File Offset: 0x001950A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B59 RID: 15193
		private static readonly MessageParser<QuitWolfBroGameCsReq> _parser = new MessageParser<QuitWolfBroGameCsReq>(() => new QuitWolfBroGameCsReq());

		// Token: 0x04003B5A RID: 15194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B5B RID: 15195
		public const int IdFieldNumber = 5;

		// Token: 0x04003B5C RID: 15196
		private uint id_;
	}
}
