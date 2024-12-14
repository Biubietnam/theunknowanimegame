using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECD RID: 3789
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterScRsp : IMessage<RogueMagicEnterScRsp>, IMessage, IEquatable<RogueMagicEnterScRsp>, IDeepCloneable<RogueMagicEnterScRsp>, IBufferMessage
	{
		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600A952 RID: 43346 RVA: 0x001C7F23 File Offset: 0x001C6123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterScRsp> Parser
		{
			get
			{
				return RogueMagicEnterScRsp._parser;
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600A953 RID: 43347 RVA: 0x001C7F2A File Offset: 0x001C612A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600A954 RID: 43348 RVA: 0x001C7F3C File Offset: 0x001C613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterScRsp.Descriptor;
			}
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x001C7F43 File Offset: 0x001C6143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterScRsp()
		{
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x001C7F4C File Offset: 0x001C614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterScRsp(RogueMagicEnterScRsp other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A957 RID: 43351 RVA: 0x001C7FB4 File Offset: 0x001C61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterScRsp Clone()
		{
			return new RogueMagicEnterScRsp(this);
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600A958 RID: 43352 RVA: 0x001C7FBC File Offset: 0x001C61BC
		// (set) Token: 0x0600A959 RID: 43353 RVA: 0x001C7FC4 File Offset: 0x001C61C4
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

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600A95A RID: 43354 RVA: 0x001C7FCD File Offset: 0x001C61CD
		// (set) Token: 0x0600A95B RID: 43355 RVA: 0x001C7FD5 File Offset: 0x001C61D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo RogueTournCurInfo
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

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600A95C RID: 43356 RVA: 0x001C7FDE File Offset: 0x001C61DE
		// (set) Token: 0x0600A95D RID: 43357 RVA: 0x001C7FE6 File Offset: 0x001C61E6
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

		// Token: 0x0600A95E RID: 43358 RVA: 0x001C7FEF File Offset: 0x001C61EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterScRsp);
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x001C8000 File Offset: 0x001C6200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x001C8064 File Offset: 0x001C6264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
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

		// Token: 0x0600A961 RID: 43361 RVA: 0x001C80CF File Offset: 0x001C62CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x001C80D7 File Offset: 0x001C62D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x001C80E0 File Offset: 0x001C62E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x001C8158 File Offset: 0x001C6358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
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

		// Token: 0x0600A965 RID: 43365 RVA: 0x001C81C8 File Offset: 0x001C63C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueMagicCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x001C825C File Offset: 0x001C645C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x001C8268 File Offset: 0x001C6468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 40U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rogueTournCurInfo_ == null)
							{
								this.RogueTournCurInfo = new RogueMagicCurInfo();
							}
							input.ReadMessage(this.RogueTournCurInfo);
						}
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

		// Token: 0x0400451D RID: 17693
		private static readonly MessageParser<RogueMagicEnterScRsp> _parser = new MessageParser<RogueMagicEnterScRsp>(() => new RogueMagicEnterScRsp());

		// Token: 0x0400451E RID: 17694
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400451F RID: 17695
		public const int RogueTournCurSceneInfoFieldNumber = 2;

		// Token: 0x04004520 RID: 17696
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x04004521 RID: 17697
		public const int RogueTournCurInfoFieldNumber = 14;

		// Token: 0x04004522 RID: 17698
		private RogueMagicCurInfo rogueTournCurInfo_;

		// Token: 0x04004523 RID: 17699
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04004524 RID: 17700
		private uint retcode_;
	}
}
