using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB1 RID: 2993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerGetFightGateCsReq : IMessage<MultiplayerGetFightGateCsReq>, IMessage, IEquatable<MultiplayerGetFightGateCsReq>, IDeepCloneable<MultiplayerGetFightGateCsReq>, IBufferMessage
	{
		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x0015D644 File Offset: 0x0015B844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerGetFightGateCsReq> Parser
		{
			get
			{
				return MultiplayerGetFightGateCsReq._parser;
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x06008466 RID: 33894 RVA: 0x0015D64B File Offset: 0x0015B84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerGetFightGateCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x0015D65D File Offset: 0x0015B85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerGetFightGateCsReq.Descriptor;
			}
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x0015D664 File Offset: 0x0015B864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateCsReq()
		{
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x0015D66C File Offset: 0x0015B86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateCsReq(MultiplayerGetFightGateCsReq other) : this()
		{
			this.playerData_ = other.playerData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x0015D691 File Offset: 0x0015B891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateCsReq Clone()
		{
			return new MultiplayerGetFightGateCsReq(this);
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x0015D699 File Offset: 0x0015B899
		// (set) Token: 0x0600846C RID: 33900 RVA: 0x0015D6A1 File Offset: 0x0015B8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlayerData
		{
			get
			{
				return this.playerData_;
			}
			set
			{
				this.playerData_ = value;
			}
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x0015D6AA File Offset: 0x0015B8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerGetFightGateCsReq);
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x0015D6B8 File Offset: 0x0015B8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerGetFightGateCsReq other)
		{
			return other != null && (other == this || (this.PlayerData == other.PlayerData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600846F RID: 33903 RVA: 0x0015D6E8 File Offset: 0x0015B8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerData != 0U)
			{
				num ^= this.PlayerData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x0015D727 File Offset: 0x0015B927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x0015D72F File Offset: 0x0015B92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x0015D738 File Offset: 0x0015B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerData != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x0015D76C File Offset: 0x0015B96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerData != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x0015D7AA File Offset: 0x0015B9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerGetFightGateCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerData != 0U)
			{
				this.PlayerData = other.PlayerData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x0015D7DB File Offset: 0x0015B9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x0015D7E4 File Offset: 0x0015B9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerData = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040032AE RID: 12974
		private static readonly MessageParser<MultiplayerGetFightGateCsReq> _parser = new MessageParser<MultiplayerGetFightGateCsReq>(() => new MultiplayerGetFightGateCsReq());

		// Token: 0x040032AF RID: 12975
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B0 RID: 12976
		public const int PlayerDataFieldNumber = 8;

		// Token: 0x040032B1 RID: 12977
		private uint playerData_;
	}
}
