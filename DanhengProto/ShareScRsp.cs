using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200114B RID: 4427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShareScRsp : IMessage<ShareScRsp>, IMessage, IEquatable<ShareScRsp>, IDeepCloneable<ShareScRsp>, IBufferMessage
	{
		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600C57B RID: 50555 RVA: 0x00211F0F File Offset: 0x0021010F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShareScRsp> Parser
		{
			get
			{
				return ShareScRsp._parser;
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x00211F16 File Offset: 0x00210116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ShareScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600C57D RID: 50557 RVA: 0x00211F28 File Offset: 0x00210128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShareScRsp.Descriptor;
			}
		}

		// Token: 0x0600C57E RID: 50558 RVA: 0x00211F2F File Offset: 0x0021012F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareScRsp()
		{
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x00211F38 File Offset: 0x00210138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareScRsp(ShareScRsp other) : this()
		{
			this.dFGNKCCPACJ_ = ((other.dFGNKCCPACJ_ != null) ? other.dFGNKCCPACJ_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C580 RID: 50560 RVA: 0x00211FA0 File Offset: 0x002101A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareScRsp Clone()
		{
			return new ShareScRsp(this);
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600C581 RID: 50561 RVA: 0x00211FA8 File Offset: 0x002101A8
		// (set) Token: 0x0600C582 RID: 50562 RVA: 0x00211FB0 File Offset: 0x002101B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShareData DFGNKCCPACJ
		{
			get
			{
				return this.dFGNKCCPACJ_;
			}
			set
			{
				this.dFGNKCCPACJ_ = value;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600C583 RID: 50563 RVA: 0x00211FB9 File Offset: 0x002101B9
		// (set) Token: 0x0600C584 RID: 50564 RVA: 0x00211FC1 File Offset: 0x002101C1
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

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600C585 RID: 50565 RVA: 0x00211FCA File Offset: 0x002101CA
		// (set) Token: 0x0600C586 RID: 50566 RVA: 0x00211FD2 File Offset: 0x002101D2
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

		// Token: 0x0600C587 RID: 50567 RVA: 0x00211FDB File Offset: 0x002101DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShareScRsp);
		}

		// Token: 0x0600C588 RID: 50568 RVA: 0x00211FEC File Offset: 0x002101EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShareScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.DFGNKCCPACJ, other.DFGNKCCPACJ) && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x00212050 File Offset: 0x00210250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dFGNKCCPACJ_ != null)
			{
				num ^= this.DFGNKCCPACJ.GetHashCode();
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

		// Token: 0x0600C58A RID: 50570 RVA: 0x002120BB File Offset: 0x002102BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x002120C3 File Offset: 0x002102C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C58C RID: 50572 RVA: 0x002120CC File Offset: 0x002102CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.dFGNKCCPACJ_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DFGNKCCPACJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x00212144 File Offset: 0x00210344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dFGNKCCPACJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DFGNKCCPACJ);
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

		// Token: 0x0600C58E RID: 50574 RVA: 0x002121B4 File Offset: 0x002103B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShareScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dFGNKCCPACJ_ != null)
			{
				if (this.dFGNKCCPACJ_ == null)
				{
					this.DFGNKCCPACJ = new ShareData();
				}
				this.DFGNKCCPACJ.MergeFrom(other.DFGNKCCPACJ);
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

		// Token: 0x0600C58F RID: 50575 RVA: 0x00212248 File Offset: 0x00210448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C590 RID: 50576 RVA: 0x00212254 File Offset: 0x00210454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 72U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.dFGNKCCPACJ_ == null)
							{
								this.DFGNKCCPACJ = new ShareData();
							}
							input.ReadMessage(this.DFGNKCCPACJ);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
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

		// Token: 0x04004FBE RID: 20414
		private static readonly MessageParser<ShareScRsp> _parser = new MessageParser<ShareScRsp>(() => new ShareScRsp());

		// Token: 0x04004FBF RID: 20415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC0 RID: 20416
		public const int DFGNKCCPACJFieldNumber = 12;

		// Token: 0x04004FC1 RID: 20417
		private ShareData dFGNKCCPACJ_;

		// Token: 0x04004FC2 RID: 20418
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004FC3 RID: 20419
		private uint retcode_;

		// Token: 0x04004FC4 RID: 20420
		public const int RewardFieldNumber = 6;

		// Token: 0x04004FC5 RID: 20421
		private ItemList reward_;
	}
}
