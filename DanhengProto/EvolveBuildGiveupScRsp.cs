using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004A9 RID: 1193
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildGiveupScRsp : IMessage<EvolveBuildGiveupScRsp>, IMessage, IEquatable<EvolveBuildGiveupScRsp>, IDeepCloneable<EvolveBuildGiveupScRsp>, IBufferMessage
	{
		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x00092F6B File Offset: 0x0009116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildGiveupScRsp> Parser
		{
			get
			{
				return EvolveBuildGiveupScRsp._parser;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x00092F72 File Offset: 0x00091172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildGiveupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x00092F84 File Offset: 0x00091184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildGiveupScRsp.Descriptor;
			}
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00092F8B File Offset: 0x0009118B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupScRsp()
		{
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x00092F94 File Offset: 0x00091194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupScRsp(EvolveBuildGiveupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00092FE0 File Offset: 0x000911E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildGiveupScRsp Clone()
		{
			return new EvolveBuildGiveupScRsp(this);
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x00092FE8 File Offset: 0x000911E8
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x00092FF0 File Offset: 0x000911F0
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

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x00092FF9 File Offset: 0x000911F9
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x00093001 File Offset: 0x00091201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0009300A File Offset: 0x0009120A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildGiveupScRsp);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00093018 File Offset: 0x00091218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildGiveupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00093068 File Offset: 0x00091268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000930BD File Offset: 0x000912BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000930C5 File Offset: 0x000912C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x000930D0 File Offset: 0x000912D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x0009312C File Offset: 0x0009132C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00093184 File Offset: 0x00091384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildGiveupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x000931EC File Offset: 0x000913EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x000931F8 File Offset: 0x000913F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 64U)
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
					if (this.levelInfo_ == null)
					{
						this.LevelInfo = new EvolveBuildLevelInfo();
					}
					input.ReadMessage(this.LevelInfo);
				}
			}
		}

		// Token: 0x04001549 RID: 5449
		private static readonly MessageParser<EvolveBuildGiveupScRsp> _parser = new MessageParser<EvolveBuildGiveupScRsp>(() => new EvolveBuildGiveupScRsp());

		// Token: 0x0400154A RID: 5450
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400154B RID: 5451
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400154C RID: 5452
		private uint retcode_;

		// Token: 0x0400154D RID: 5453
		public const int LevelInfoFieldNumber = 1;

		// Token: 0x0400154E RID: 5454
		private EvolveBuildLevelInfo levelInfo_;
	}
}
