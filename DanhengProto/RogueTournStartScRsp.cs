using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101F RID: 4127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournStartScRsp : IMessage<RogueTournStartScRsp>, IMessage, IEquatable<RogueTournStartScRsp>, IDeepCloneable<RogueTournStartScRsp>, IBufferMessage
	{
		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600B782 RID: 46978 RVA: 0x001EC5F7 File Offset: 0x001EA7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournStartScRsp> Parser
		{
			get
			{
				return RogueTournStartScRsp._parser;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600B783 RID: 46979 RVA: 0x001EC5FE File Offset: 0x001EA7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournStartScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600B784 RID: 46980 RVA: 0x001EC610 File Offset: 0x001EA810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournStartScRsp.Descriptor;
			}
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x001EC617 File Offset: 0x001EA817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartScRsp()
		{
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x001EC620 File Offset: 0x001EA820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartScRsp(RogueTournStartScRsp other) : this()
		{
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.week_ = other.week_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x001EC694 File Offset: 0x001EA894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartScRsp Clone()
		{
			return new RogueTournStartScRsp(this);
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600B788 RID: 46984 RVA: 0x001EC69C File Offset: 0x001EA89C
		// (set) Token: 0x0600B789 RID: 46985 RVA: 0x001EC6A4 File Offset: 0x001EA8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600B78A RID: 46986 RVA: 0x001EC6AD File Offset: 0x001EA8AD
		// (set) Token: 0x0600B78B RID: 46987 RVA: 0x001EC6B5 File Offset: 0x001EA8B5
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

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600B78C RID: 46988 RVA: 0x001EC6BE File Offset: 0x001EA8BE
		// (set) Token: 0x0600B78D RID: 46989 RVA: 0x001EC6C6 File Offset: 0x001EA8C6
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

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600B78E RID: 46990 RVA: 0x001EC6CF File Offset: 0x001EA8CF
		// (set) Token: 0x0600B78F RID: 46991 RVA: 0x001EC6D7 File Offset: 0x001EA8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Week
		{
			get
			{
				return this.week_;
			}
			set
			{
				this.week_ = value;
			}
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x001EC6E0 File Offset: 0x001EA8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournStartScRsp);
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x001EC6F0 File Offset: 0x001EA8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournStartScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && this.Week == other.Week && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x001EC764 File Offset: 0x001EA964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.Week != 0U)
			{
				num ^= this.Week.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x001EC7E8 File Offset: 0x001EA9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x001EC7F0 File Offset: 0x001EA9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x001EC7FC File Offset: 0x001EA9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Week != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Week);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x001EC890 File Offset: 0x001EAA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.Week != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Week);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x001EC918 File Offset: 0x001EAB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournStartScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueTournCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
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
			if (other.Week != 0U)
			{
				this.Week = other.Week;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x001EC9C0 File Offset: 0x001EABC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x001EC9CC File Offset: 0x001EABCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 10U)
					{
						if (this.rogueTournCurInfo_ == null)
						{
							this.RogueTournCurInfo = new RogueTournCurInfo();
						}
						input.ReadMessage(this.RogueTournCurInfo);
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Week = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A58 RID: 19032
		private static readonly MessageParser<RogueTournStartScRsp> _parser = new MessageParser<RogueTournStartScRsp>(() => new RogueTournStartScRsp());

		// Token: 0x04004A59 RID: 19033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A5A RID: 19034
		public const int RogueTournCurInfoFieldNumber = 1;

		// Token: 0x04004A5B RID: 19035
		private RogueTournCurInfo rogueTournCurInfo_;

		// Token: 0x04004A5C RID: 19036
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04004A5D RID: 19037
		private uint retcode_;

		// Token: 0x04004A5E RID: 19038
		public const int RogueTournCurSceneInfoFieldNumber = 10;

		// Token: 0x04004A5F RID: 19039
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x04004A60 RID: 19040
		public const int WeekFieldNumber = 15;

		// Token: 0x04004A61 RID: 19041
		private uint week_;
	}
}
