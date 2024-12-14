using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200108B RID: 4235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneReviveAfterRebattleScRsp : IMessage<SceneReviveAfterRebattleScRsp>, IMessage, IEquatable<SceneReviveAfterRebattleScRsp>, IDeepCloneable<SceneReviveAfterRebattleScRsp>, IBufferMessage
	{
		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x001FD0F8 File Offset: 0x001FB2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneReviveAfterRebattleScRsp> Parser
		{
			get
			{
				return SceneReviveAfterRebattleScRsp._parser;
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600BCD7 RID: 48343 RVA: 0x001FD0FF File Offset: 0x001FB2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneReviveAfterRebattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x001FD111 File Offset: 0x001FB311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneReviveAfterRebattleScRsp.Descriptor;
			}
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x001FD118 File Offset: 0x001FB318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleScRsp()
		{
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x001FD120 File Offset: 0x001FB320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleScRsp(SceneReviveAfterRebattleScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x001FD145 File Offset: 0x001FB345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneReviveAfterRebattleScRsp Clone()
		{
			return new SceneReviveAfterRebattleScRsp(this);
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x001FD14D File Offset: 0x001FB34D
		// (set) Token: 0x0600BCDD RID: 48349 RVA: 0x001FD155 File Offset: 0x001FB355
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

		// Token: 0x0600BCDE RID: 48350 RVA: 0x001FD15E File Offset: 0x001FB35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneReviveAfterRebattleScRsp);
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x001FD16C File Offset: 0x001FB36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneReviveAfterRebattleScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x001FD19C File Offset: 0x001FB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x001FD1DB File Offset: 0x001FB3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x001FD1E3 File Offset: 0x001FB3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x001FD1EC File Offset: 0x001FB3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x001FD220 File Offset: 0x001FB420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x001FD25E File Offset: 0x001FB45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneReviveAfterRebattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x001FD28F File Offset: 0x001FB48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x001FD298 File Offset: 0x001FB498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
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
		}

		// Token: 0x04004CCD RID: 19661
		private static readonly MessageParser<SceneReviveAfterRebattleScRsp> _parser = new MessageParser<SceneReviveAfterRebattleScRsp>(() => new SceneReviveAfterRebattleScRsp());

		// Token: 0x04004CCE RID: 19662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CCF RID: 19663
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04004CD0 RID: 19664
		private uint retcode_;
	}
}
