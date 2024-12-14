using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000033 RID: 51
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivateFarmElementScRsp : IMessage<ActivateFarmElementScRsp>, IMessage, IEquatable<ActivateFarmElementScRsp>, IDeepCloneable<ActivateFarmElementScRsp>, IBufferMessage
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00006625 File Offset: 0x00004825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivateFarmElementScRsp> Parser
		{
			get
			{
				return ActivateFarmElementScRsp._parser;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000662C File Offset: 0x0000482C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivateFarmElementScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000663E File Offset: 0x0000483E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateFarmElementScRsp.Descriptor;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006645 File Offset: 0x00004845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementScRsp()
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000664D File Offset: 0x0000484D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementScRsp(ActivateFarmElementScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.entityId_ = other.entityId_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000668A File Offset: 0x0000488A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementScRsp Clone()
		{
			return new ActivateFarmElementScRsp(this);
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00006692 File Offset: 0x00004892
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000669A File Offset: 0x0000489A
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000066A3 File Offset: 0x000048A3
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000066AB File Offset: 0x000048AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000066BC File Offset: 0x000048BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000066C5 File Offset: 0x000048C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateFarmElementScRsp);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000066D4 File Offset: 0x000048D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateFarmElementScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.EntityId == other.EntityId && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006730 File Offset: 0x00004930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000067A1 File Offset: 0x000049A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000067A9 File Offset: 0x000049A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000067B4 File Offset: 0x000049B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EntityId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000682C File Offset: 0x00004A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000689C File Offset: 0x00004A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateFarmElementScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00006900 File Offset: 0x00004B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000690C File Offset: 0x00004B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 112U)
					{
						if (num != 120U)
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
						this.EntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.WorldLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly MessageParser<ActivateFarmElementScRsp> _parser = new MessageParser<ActivateFarmElementScRsp>(() => new ActivateFarmElementScRsp());

		// Token: 0x040000A6 RID: 166
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000A7 RID: 167
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040000A8 RID: 168
		private uint retcode_;

		// Token: 0x040000A9 RID: 169
		public const int EntityIdFieldNumber = 14;

		// Token: 0x040000AA RID: 170
		private uint entityId_;

		// Token: 0x040000AB RID: 171
		public const int WorldLevelFieldNumber = 10;

		// Token: 0x040000AC RID: 172
		private uint worldLevel_;
	}
}
