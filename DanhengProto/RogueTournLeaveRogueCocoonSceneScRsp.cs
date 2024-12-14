using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE7 RID: 4071
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLeaveRogueCocoonSceneScRsp : IMessage<RogueTournLeaveRogueCocoonSceneScRsp>, IMessage, IEquatable<RogueTournLeaveRogueCocoonSceneScRsp>, IDeepCloneable<RogueTournLeaveRogueCocoonSceneScRsp>, IBufferMessage
	{
		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600B530 RID: 46384 RVA: 0x001E653B File Offset: 0x001E473B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLeaveRogueCocoonSceneScRsp> Parser
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneScRsp._parser;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600B531 RID: 46385 RVA: 0x001E6542 File Offset: 0x001E4742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600B532 RID: 46386 RVA: 0x001E6554 File Offset: 0x001E4754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneScRsp.Descriptor;
			}
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x001E655B File Offset: 0x001E475B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneScRsp()
		{
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x001E6564 File Offset: 0x001E4764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneScRsp(RogueTournLeaveRogueCocoonSceneScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x001E65B0 File Offset: 0x001E47B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneScRsp Clone()
		{
			return new RogueTournLeaveRogueCocoonSceneScRsp(this);
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600B536 RID: 46390 RVA: 0x001E65B8 File Offset: 0x001E47B8
		// (set) Token: 0x0600B537 RID: 46391 RVA: 0x001E65C0 File Offset: 0x001E47C0
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

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600B538 RID: 46392 RVA: 0x001E65C9 File Offset: 0x001E47C9
		// (set) Token: 0x0600B539 RID: 46393 RVA: 0x001E65D1 File Offset: 0x001E47D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x001E65DA File Offset: 0x001E47DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLeaveRogueCocoonSceneScRsp);
		}

		// Token: 0x0600B53B RID: 46395 RVA: 0x001E65E8 File Offset: 0x001E47E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLeaveRogueCocoonSceneScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x001E6638 File Offset: 0x001E4838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x001E668D File Offset: 0x001E488D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x001E6695 File Offset: 0x001E4895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x001E66A0 File Offset: 0x001E48A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueTournCurSceneInfo);
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

		// Token: 0x0600B540 RID: 46400 RVA: 0x001E66FC File Offset: 0x001E48FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x001E6754 File Offset: 0x001E4954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLeaveRogueCocoonSceneScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x001E67BC File Offset: 0x001E49BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x001E67C8 File Offset: 0x001E49C8
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
					if (this.rogueTournCurSceneInfo_ == null)
					{
						this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x0400497C RID: 18812
		private static readonly MessageParser<RogueTournLeaveRogueCocoonSceneScRsp> _parser = new MessageParser<RogueTournLeaveRogueCocoonSceneScRsp>(() => new RogueTournLeaveRogueCocoonSceneScRsp());

		// Token: 0x0400497D RID: 18813
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400497E RID: 18814
		public const int RetcodeFieldNumber = 2;

		// Token: 0x0400497F RID: 18815
		private uint retcode_;

		// Token: 0x04004980 RID: 18816
		public const int RogueTournCurSceneInfoFieldNumber = 1;

		// Token: 0x04004981 RID: 18817
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;
	}
}
