using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4F RID: 3407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitRogueCsReq : IMessage<QuitRogueCsReq>, IMessage, IEquatable<QuitRogueCsReq>, IDeepCloneable<QuitRogueCsReq>, IBufferMessage
	{
		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x06009840 RID: 38976 RVA: 0x00195B7C File Offset: 0x00193D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitRogueCsReq> Parser
		{
			get
			{
				return QuitRogueCsReq._parser;
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x00195B83 File Offset: 0x00193D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitRogueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x06009842 RID: 38978 RVA: 0x00195B95 File Offset: 0x00193D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitRogueCsReq.Descriptor;
			}
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x00195B9C File Offset: 0x00193D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueCsReq()
		{
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x00195BA4 File Offset: 0x00193DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueCsReq(QuitRogueCsReq other) : this()
		{
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x00195BC9 File Offset: 0x00193DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitRogueCsReq Clone()
		{
			return new QuitRogueCsReq(this);
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x06009846 RID: 38982 RVA: 0x00195BD1 File Offset: 0x00193DD1
		// (set) Token: 0x06009847 RID: 38983 RVA: 0x00195BD9 File Offset: 0x00193DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x00195BE2 File Offset: 0x00193DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitRogueCsReq);
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x00195BF0 File Offset: 0x00193DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitRogueCsReq other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x00195C20 File Offset: 0x00193E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x00195C5F File Offset: 0x00193E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x00195C67 File Offset: 0x00193E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600984D RID: 38989 RVA: 0x00195C70 File Offset: 0x00193E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x00195CA4 File Offset: 0x00193EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x00195CE2 File Offset: 0x00193EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitRogueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x00195D13 File Offset: 0x00193F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x00195D1C File Offset: 0x00193F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B35 RID: 15157
		private static readonly MessageParser<QuitRogueCsReq> _parser = new MessageParser<QuitRogueCsReq>(() => new QuitRogueCsReq());

		// Token: 0x04003B36 RID: 15158
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B37 RID: 15159
		public const int AreaIdFieldNumber = 4;

		// Token: 0x04003B38 RID: 15160
		private uint areaId_;
	}
}
