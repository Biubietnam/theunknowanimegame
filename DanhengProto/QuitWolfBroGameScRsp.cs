using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D5D RID: 3421
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitWolfBroGameScRsp : IMessage<QuitWolfBroGameScRsp>, IMessage, IEquatable<QuitWolfBroGameScRsp>, IDeepCloneable<QuitWolfBroGameScRsp>, IBufferMessage
	{
		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x00196F8D File Offset: 0x0019518D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitWolfBroGameScRsp> Parser
		{
			get
			{
				return QuitWolfBroGameScRsp._parser;
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x00196F94 File Offset: 0x00195194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitWolfBroGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x060098DB RID: 39131 RVA: 0x00196FA6 File Offset: 0x001951A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitWolfBroGameScRsp.Descriptor;
			}
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x00196FAD File Offset: 0x001951AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameScRsp()
		{
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00196FB8 File Offset: 0x001951B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameScRsp(QuitWolfBroGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x00197004 File Offset: 0x00195204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitWolfBroGameScRsp Clone()
		{
			return new QuitWolfBroGameScRsp(this);
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x060098DF RID: 39135 RVA: 0x0019700C File Offset: 0x0019520C
		// (set) Token: 0x060098E0 RID: 39136 RVA: 0x00197014 File Offset: 0x00195214
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

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x060098E1 RID: 39137 RVA: 0x0019701D File Offset: 0x0019521D
		// (set) Token: 0x060098E2 RID: 39138 RVA: 0x00197025 File Offset: 0x00195225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x0019702E File Offset: 0x0019522E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitWolfBroGameScRsp);
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x0019703C File Offset: 0x0019523C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitWolfBroGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.WolfBroGameData, other.WolfBroGameData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x0019708C File Offset: 0x0019528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x001970E1 File Offset: 0x001952E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x001970E9 File Offset: 0x001952E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x001970F4 File Offset: 0x001952F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x00197150 File Offset: 0x00195350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x001971A8 File Offset: 0x001953A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitWolfBroGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x00197210 File Offset: 0x00195410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x0019721C File Offset: 0x0019541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
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
					if (this.wolfBroGameData_ == null)
					{
						this.WolfBroGameData = new WolfBroGameData();
					}
					input.ReadMessage(this.WolfBroGameData);
				}
			}
		}

		// Token: 0x04003B5E RID: 15198
		private static readonly MessageParser<QuitWolfBroGameScRsp> _parser = new MessageParser<QuitWolfBroGameScRsp>(() => new QuitWolfBroGameScRsp());

		// Token: 0x04003B5F RID: 15199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B60 RID: 15200
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04003B61 RID: 15201
		private uint retcode_;

		// Token: 0x04003B62 RID: 15202
		public const int WolfBroGameDataFieldNumber = 1;

		// Token: 0x04003B63 RID: 15203
		private WolfBroGameData wolfBroGameData_;
	}
}
