using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000547 RID: 1351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3DataCsReq : IMessage<FightMatch3DataCsReq>, IMessage, IEquatable<FightMatch3DataCsReq>, IDeepCloneable<FightMatch3DataCsReq>, IBufferMessage
	{
		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x000A50C4 File Offset: 0x000A32C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3DataCsReq> Parser
		{
			get
			{
				return FightMatch3DataCsReq._parser;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x000A50CB File Offset: 0x000A32CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3DataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x000A50DD File Offset: 0x000A32DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3DataCsReq.Descriptor;
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x000A50E4 File Offset: 0x000A32E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataCsReq()
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x000A50EC File Offset: 0x000A32EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataCsReq(FightMatch3DataCsReq other) : this()
		{
			this.playerData_ = other.playerData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x000A5111 File Offset: 0x000A3311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3DataCsReq Clone()
		{
			return new FightMatch3DataCsReq(this);
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x000A5119 File Offset: 0x000A3319
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x000A5121 File Offset: 0x000A3321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerData
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

		// Token: 0x06003C3B RID: 15419 RVA: 0x000A512A File Offset: 0x000A332A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3DataCsReq);
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x000A5138 File Offset: 0x000A3338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3DataCsReq other)
		{
			return other != null && (other == this || (this.PlayerData == other.PlayerData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000A5168 File Offset: 0x000A3368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerData != 0)
			{
				num ^= this.PlayerData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x000A51A7 File Offset: 0x000A33A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x000A51AF File Offset: 0x000A33AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000A51B8 File Offset: 0x000A33B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerData != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x000A51EC File Offset: 0x000A33EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerData != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000A522A File Offset: 0x000A342A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3DataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerData != 0)
			{
				this.PlayerData = other.PlayerData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x000A525B File Offset: 0x000A345B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x000A5264 File Offset: 0x000A3464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerData = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400182C RID: 6188
		private static readonly MessageParser<FightMatch3DataCsReq> _parser = new MessageParser<FightMatch3DataCsReq>(() => new FightMatch3DataCsReq());

		// Token: 0x0400182D RID: 6189
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400182E RID: 6190
		public const int PlayerDataFieldNumber = 14;

		// Token: 0x0400182F RID: 6191
		private int playerData_;
	}
}
