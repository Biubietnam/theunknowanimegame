using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A9F RID: 2719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeGetDataScRsp : IMessage<MatchThreeGetDataScRsp>, IMessage, IEquatable<MatchThreeGetDataScRsp>, IDeepCloneable<MatchThreeGetDataScRsp>, IBufferMessage
	{
		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x0013F41D File Offset: 0x0013D61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeGetDataScRsp> Parser
		{
			get
			{
				return MatchThreeGetDataScRsp._parser;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x0013F424 File Offset: 0x0013D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeGetDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06007879 RID: 30841 RVA: 0x0013F436 File Offset: 0x0013D636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeGetDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x0013F43D File Offset: 0x0013D63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataScRsp()
		{
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x0013F448 File Offset: 0x0013D648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataScRsp(MatchThreeGetDataScRsp other) : this()
		{
			this.lCPHAAIIPOJ_ = ((other.lCPHAAIIPOJ_ != null) ? other.lCPHAAIIPOJ_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x0013F494 File Offset: 0x0013D694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeGetDataScRsp Clone()
		{
			return new MatchThreeGetDataScRsp(this);
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600787D RID: 30845 RVA: 0x0013F49C File Offset: 0x0013D69C
		// (set) Token: 0x0600787E RID: 30846 RVA: 0x0013F4A4 File Offset: 0x0013D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PBKKDOPNNJA LCPHAAIIPOJ
		{
			get
			{
				return this.lCPHAAIIPOJ_;
			}
			set
			{
				this.lCPHAAIIPOJ_ = value;
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x0013F4AD File Offset: 0x0013D6AD
		// (set) Token: 0x06007880 RID: 30848 RVA: 0x0013F4B5 File Offset: 0x0013D6B5
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

		// Token: 0x06007881 RID: 30849 RVA: 0x0013F4BE File Offset: 0x0013D6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeGetDataScRsp);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0013F4CC File Offset: 0x0013D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeGetDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LCPHAAIIPOJ, other.LCPHAAIIPOJ) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x0013F51C File Offset: 0x0013D71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lCPHAAIIPOJ_ != null)
			{
				num ^= this.LCPHAAIIPOJ.GetHashCode();
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

		// Token: 0x06007884 RID: 30852 RVA: 0x0013F571 File Offset: 0x0013D771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x0013F579 File Offset: 0x0013D779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x0013F584 File Offset: 0x0013D784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lCPHAAIIPOJ_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.LCPHAAIIPOJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x0013F5E0 File Offset: 0x0013D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lCPHAAIIPOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LCPHAAIIPOJ);
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

		// Token: 0x06007888 RID: 30856 RVA: 0x0013F638 File Offset: 0x0013D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeGetDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lCPHAAIIPOJ_ != null)
			{
				if (this.lCPHAAIIPOJ_ == null)
				{
					this.LCPHAAIIPOJ = new PBKKDOPNNJA();
				}
				this.LCPHAAIIPOJ.MergeFrom(other.LCPHAAIIPOJ);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x0013F6A0 File Offset: 0x0013D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x0013F6AC File Offset: 0x0013D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lCPHAAIIPOJ_ == null)
						{
							this.LCPHAAIIPOJ = new PBKKDOPNNJA();
						}
						input.ReadMessage(this.LCPHAAIIPOJ);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E3E RID: 11838
		private static readonly MessageParser<MatchThreeGetDataScRsp> _parser = new MessageParser<MatchThreeGetDataScRsp>(() => new MatchThreeGetDataScRsp());

		// Token: 0x04002E3F RID: 11839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E40 RID: 11840
		public const int LCPHAAIIPOJFieldNumber = 9;

		// Token: 0x04002E41 RID: 11841
		private PBKKDOPNNJA lCPHAAIIPOJ_;

		// Token: 0x04002E42 RID: 11842
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002E43 RID: 11843
		private uint retcode_;
	}
}
