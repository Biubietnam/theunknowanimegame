using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004AD RID: 1197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildLeaveScRsp : IMessage<EvolveBuildLeaveScRsp>, IMessage, IEquatable<EvolveBuildLeaveScRsp>, IDeepCloneable<EvolveBuildLeaveScRsp>, IBufferMessage
	{
		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x000934CF File Offset: 0x000916CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildLeaveScRsp> Parser
		{
			get
			{
				return EvolveBuildLeaveScRsp._parser;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x000934D6 File Offset: 0x000916D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildLeaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x000934E8 File Offset: 0x000916E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildLeaveScRsp.Descriptor;
			}
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x000934EF File Offset: 0x000916EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveScRsp()
		{
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000934F8 File Offset: 0x000916F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveScRsp(EvolveBuildLeaveScRsp other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00093544 File Offset: 0x00091744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLeaveScRsp Clone()
		{
			return new EvolveBuildLeaveScRsp(this);
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x0009354C File Offset: 0x0009174C
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x00093554 File Offset: 0x00091754
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

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x0009355D File Offset: 0x0009175D
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x00093565 File Offset: 0x00091765
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

		// Token: 0x06003588 RID: 13704 RVA: 0x0009356E File Offset: 0x0009176E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildLeaveScRsp);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0009357C File Offset: 0x0009177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildLeaveScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x000935CC File Offset: 0x000917CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00093621 File Offset: 0x00091821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00093629 File Offset: 0x00091829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00093634 File Offset: 0x00091834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.LevelInfo);
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

		// Token: 0x0600358E RID: 13710 RVA: 0x00093690 File Offset: 0x00091890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000936E8 File Offset: 0x000918E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildLeaveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00093750 File Offset: 0x00091950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0009375C File Offset: 0x0009195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
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
					if (this.levelInfo_ == null)
					{
						this.LevelInfo = new EvolveBuildLevelInfo();
					}
					input.ReadMessage(this.LevelInfo);
				}
			}
		}

		// Token: 0x04001553 RID: 5459
		private static readonly MessageParser<EvolveBuildLeaveScRsp> _parser = new MessageParser<EvolveBuildLeaveScRsp>(() => new EvolveBuildLeaveScRsp());

		// Token: 0x04001554 RID: 5460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001555 RID: 5461
		public const int LevelInfoFieldNumber = 7;

		// Token: 0x04001556 RID: 5462
		private EvolveBuildLevelInfo levelInfo_;

		// Token: 0x04001557 RID: 5463
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04001558 RID: 5464
		private uint retcode_;
	}
}
