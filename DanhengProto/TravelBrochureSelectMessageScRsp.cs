using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001385 RID: 4997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSelectMessageScRsp : IMessage<TravelBrochureSelectMessageScRsp>, IMessage, IEquatable<TravelBrochureSelectMessageScRsp>, IDeepCloneable<TravelBrochureSelectMessageScRsp>, IBufferMessage
	{
		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x0025135B File Offset: 0x0024F55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSelectMessageScRsp> Parser
		{
			get
			{
				return TravelBrochureSelectMessageScRsp._parser;
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600DEEC RID: 57068 RVA: 0x00251362 File Offset: 0x0024F562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSelectMessageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600DEED RID: 57069 RVA: 0x00251374 File Offset: 0x0024F574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSelectMessageScRsp.Descriptor;
			}
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x0025137B File Offset: 0x0024F57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageScRsp()
		{
		}

		// Token: 0x0600DEEF RID: 57071 RVA: 0x00251384 File Offset: 0x0024F584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageScRsp(TravelBrochureSelectMessageScRsp other) : this()
		{
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEF0 RID: 57072 RVA: 0x002513EC File Offset: 0x0024F5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageScRsp Clone()
		{
			return new TravelBrochureSelectMessageScRsp(this);
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600DEF1 RID: 57073 RVA: 0x002513F4 File Offset: 0x0024F5F4
		// (set) Token: 0x0600DEF2 RID: 57074 RVA: 0x002513FC File Offset: 0x0024F5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG GKAPDOCPCJM
		{
			get
			{
				return this.gKAPDOCPCJM_;
			}
			set
			{
				this.gKAPDOCPCJM_ = value;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600DEF3 RID: 57075 RVA: 0x00251405 File Offset: 0x0024F605
		// (set) Token: 0x0600DEF4 RID: 57076 RVA: 0x0025140D File Offset: 0x0024F60D
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

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x00251416 File Offset: 0x0024F616
		// (set) Token: 0x0600DEF6 RID: 57078 RVA: 0x0025141E File Offset: 0x0024F61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x0600DEF7 RID: 57079 RVA: 0x00251427 File Offset: 0x0024F627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSelectMessageScRsp);
		}

		// Token: 0x0600DEF8 RID: 57080 RVA: 0x00251438 File Offset: 0x0024F638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSelectMessageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEF9 RID: 57081 RVA: 0x0025149C File Offset: 0x0024F69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gKAPDOCPCJM_ != null)
			{
				num ^= this.GKAPDOCPCJM.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEFA RID: 57082 RVA: 0x00251507 File Offset: 0x0024F707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DEFB RID: 57083 RVA: 0x0025150F File Offset: 0x0024F70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEFC RID: 57084 RVA: 0x00251518 File Offset: 0x0024F718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEFD RID: 57085 RVA: 0x00251590 File Offset: 0x0024F790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gKAPDOCPCJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKAPDOCPCJM);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEFE RID: 57086 RVA: 0x00251600 File Offset: 0x0024F800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSelectMessageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gKAPDOCPCJM_ != null)
			{
				if (this.gKAPDOCPCJM_ == null)
				{
					this.GKAPDOCPCJM = new KHKLKHNGDOG();
				}
				this.GKAPDOCPCJM.MergeFrom(other.GKAPDOCPCJM);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEFF RID: 57087 RVA: 0x00251694 File Offset: 0x0024F894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF00 RID: 57088 RVA: 0x002516A0 File Offset: 0x0024F8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 74U)
					{
						if (num != 88U)
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
						if (this.gKAPDOCPCJM_ == null)
						{
							this.GKAPDOCPCJM = new KHKLKHNGDOG();
						}
						input.ReadMessage(this.GKAPDOCPCJM);
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x04005899 RID: 22681
		private static readonly MessageParser<TravelBrochureSelectMessageScRsp> _parser = new MessageParser<TravelBrochureSelectMessageScRsp>(() => new TravelBrochureSelectMessageScRsp());

		// Token: 0x0400589A RID: 22682
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400589B RID: 22683
		public const int GKAPDOCPCJMFieldNumber = 9;

		// Token: 0x0400589C RID: 22684
		private KHKLKHNGDOG gKAPDOCPCJM_;

		// Token: 0x0400589D RID: 22685
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400589E RID: 22686
		private uint retcode_;

		// Token: 0x0400589F RID: 22687
		public const int RewardFieldNumber = 3;

		// Token: 0x040058A0 RID: 22688
		private ItemList reward_;
	}
}
