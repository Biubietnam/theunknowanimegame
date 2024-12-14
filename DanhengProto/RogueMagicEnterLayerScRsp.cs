using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC7 RID: 3783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterLayerScRsp : IMessage<RogueMagicEnterLayerScRsp>, IMessage, IEquatable<RogueMagicEnterLayerScRsp>, IDeepCloneable<RogueMagicEnterLayerScRsp>, IBufferMessage
	{
		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600A90D RID: 43277 RVA: 0x001C746B File Offset: 0x001C566B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterLayerScRsp> Parser
		{
			get
			{
				return RogueMagicEnterLayerScRsp._parser;
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600A90E RID: 43278 RVA: 0x001C7472 File Offset: 0x001C5672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterLayerScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x001C7484 File Offset: 0x001C5684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterLayerScRsp.Descriptor;
			}
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x001C748B File Offset: 0x001C568B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerScRsp()
		{
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x001C7494 File Offset: 0x001C5694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerScRsp(RogueMagicEnterLayerScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x001C74E0 File Offset: 0x001C56E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterLayerScRsp Clone()
		{
			return new RogueMagicEnterLayerScRsp(this);
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x001C74E8 File Offset: 0x001C56E8
		// (set) Token: 0x0600A914 RID: 43284 RVA: 0x001C74F0 File Offset: 0x001C56F0
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

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0600A915 RID: 43285 RVA: 0x001C74F9 File Offset: 0x001C56F9
		// (set) Token: 0x0600A916 RID: 43286 RVA: 0x001C7501 File Offset: 0x001C5701
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

		// Token: 0x0600A917 RID: 43287 RVA: 0x001C750A File Offset: 0x001C570A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterLayerScRsp);
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x001C7518 File Offset: 0x001C5718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterLayerScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x001C7568 File Offset: 0x001C5768
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

		// Token: 0x0600A91A RID: 43290 RVA: 0x001C75BD File Offset: 0x001C57BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x001C75C5 File Offset: 0x001C57C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x001C75D0 File Offset: 0x001C57D0
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
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x001C762C File Offset: 0x001C582C
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

		// Token: 0x0600A91E RID: 43294 RVA: 0x001C7684 File Offset: 0x001C5884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterLayerScRsp other)
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

		// Token: 0x0600A91F RID: 43295 RVA: 0x001C76EC File Offset: 0x001C58EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x001C76F8 File Offset: 0x001C58F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
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
					if (this.rogueTournCurSceneInfo_ == null)
					{
						this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x04004508 RID: 17672
		private static readonly MessageParser<RogueMagicEnterLayerScRsp> _parser = new MessageParser<RogueMagicEnterLayerScRsp>(() => new RogueMagicEnterLayerScRsp());

		// Token: 0x04004509 RID: 17673
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400450A RID: 17674
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400450B RID: 17675
		private uint retcode_;

		// Token: 0x0400450C RID: 17676
		public const int RogueTournCurSceneInfoFieldNumber = 4;

		// Token: 0x0400450D RID: 17677
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;
	}
}
