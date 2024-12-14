using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA5 RID: 4005
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterLayerScRsp : IMessage<RogueTournEnterLayerScRsp>, IMessage, IEquatable<RogueTournEnterLayerScRsp>, IDeepCloneable<RogueTournEnterLayerScRsp>, IBufferMessage
	{
		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x001DF66B File Offset: 0x001DD86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterLayerScRsp> Parser
		{
			get
			{
				return RogueTournEnterLayerScRsp._parser;
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x001DF672 File Offset: 0x001DD872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterLayerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600B271 RID: 45681 RVA: 0x001DF684 File Offset: 0x001DD884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterLayerScRsp.Descriptor;
			}
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x001DF68B File Offset: 0x001DD88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerScRsp()
		{
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x001DF694 File Offset: 0x001DD894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerScRsp(RogueTournEnterLayerScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x001DF6E0 File Offset: 0x001DD8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerScRsp Clone()
		{
			return new RogueTournEnterLayerScRsp(this);
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600B275 RID: 45685 RVA: 0x001DF6E8 File Offset: 0x001DD8E8
		// (set) Token: 0x0600B276 RID: 45686 RVA: 0x001DF6F0 File Offset: 0x001DD8F0
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

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600B277 RID: 45687 RVA: 0x001DF6F9 File Offset: 0x001DD8F9
		// (set) Token: 0x0600B278 RID: 45688 RVA: 0x001DF701 File Offset: 0x001DD901
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

		// Token: 0x0600B279 RID: 45689 RVA: 0x001DF70A File Offset: 0x001DD90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterLayerScRsp);
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x001DF718 File Offset: 0x001DD918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterLayerScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x001DF768 File Offset: 0x001DD968
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

		// Token: 0x0600B27C RID: 45692 RVA: 0x001DF7BD File Offset: 0x001DD9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x001DF7C5 File Offset: 0x001DD9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x001DF7D0 File Offset: 0x001DD9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x001DF82C File Offset: 0x001DDA2C
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

		// Token: 0x0600B280 RID: 45696 RVA: 0x001DF884 File Offset: 0x001DDA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterLayerScRsp other)
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

		// Token: 0x0600B281 RID: 45697 RVA: 0x001DF8EC File Offset: 0x001DDAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x001DF8F8 File Offset: 0x001DDAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 72U)
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

		// Token: 0x04004882 RID: 18562
		private static readonly MessageParser<RogueTournEnterLayerScRsp> _parser = new MessageParser<RogueTournEnterLayerScRsp>(() => new RogueTournEnterLayerScRsp());

		// Token: 0x04004883 RID: 18563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004884 RID: 18564
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004885 RID: 18565
		private uint retcode_;

		// Token: 0x04004886 RID: 18566
		public const int RogueTournCurSceneInfoFieldNumber = 7;

		// Token: 0x04004887 RID: 18567
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;
	}
}
