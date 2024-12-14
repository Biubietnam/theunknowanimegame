using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECB RID: 3787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterRoomScRsp : IMessage<RogueMagicEnterRoomScRsp>, IMessage, IEquatable<RogueMagicEnterRoomScRsp>, IDeepCloneable<RogueMagicEnterRoomScRsp>, IBufferMessage
	{
		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600A93B RID: 43323 RVA: 0x001C7B53 File Offset: 0x001C5D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterRoomScRsp> Parser
		{
			get
			{
				return RogueMagicEnterRoomScRsp._parser;
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0600A93C RID: 43324 RVA: 0x001C7B5A File Offset: 0x001C5D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600A93D RID: 43325 RVA: 0x001C7B6C File Offset: 0x001C5D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterRoomScRsp.Descriptor;
			}
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x001C7B73 File Offset: 0x001C5D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomScRsp()
		{
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x001C7B7C File Offset: 0x001C5D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomScRsp(RogueMagicEnterRoomScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x001C7BC8 File Offset: 0x001C5DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterRoomScRsp Clone()
		{
			return new RogueMagicEnterRoomScRsp(this);
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600A941 RID: 43329 RVA: 0x001C7BD0 File Offset: 0x001C5DD0
		// (set) Token: 0x0600A942 RID: 43330 RVA: 0x001C7BD8 File Offset: 0x001C5DD8
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

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600A943 RID: 43331 RVA: 0x001C7BE1 File Offset: 0x001C5DE1
		// (set) Token: 0x0600A944 RID: 43332 RVA: 0x001C7BE9 File Offset: 0x001C5DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo RogueTournCurSceneInfo
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

		// Token: 0x0600A945 RID: 43333 RVA: 0x001C7BF2 File Offset: 0x001C5DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterRoomScRsp);
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x001C7C00 File Offset: 0x001C5E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterRoomScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x001C7C50 File Offset: 0x001C5E50
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

		// Token: 0x0600A948 RID: 43336 RVA: 0x001C7CA5 File Offset: 0x001C5EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x001C7CAD File Offset: 0x001C5EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x001C7CB8 File Offset: 0x001C5EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A94B RID: 43339 RVA: 0x001C7D14 File Offset: 0x001C5F14
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

		// Token: 0x0600A94C RID: 43340 RVA: 0x001C7D6C File Offset: 0x001C5F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterRoomScRsp other)
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
					this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A94D RID: 43341 RVA: 0x001C7DD4 File Offset: 0x001C5FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A94E RID: 43342 RVA: 0x001C7DE0 File Offset: 0x001C5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 112U)
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
						this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x04004516 RID: 17686
		private static readonly MessageParser<RogueMagicEnterRoomScRsp> _parser = new MessageParser<RogueMagicEnterRoomScRsp>(() => new RogueMagicEnterRoomScRsp());

		// Token: 0x04004517 RID: 17687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004518 RID: 17688
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04004519 RID: 17689
		private uint retcode_;

		// Token: 0x0400451A RID: 17690
		public const int RogueTournCurSceneInfoFieldNumber = 4;

		// Token: 0x0400451B RID: 17691
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;
	}
}
