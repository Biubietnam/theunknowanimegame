using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011CF RID: 4559
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTimedCocoonStageScRsp : IMessage<StartTimedCocoonStageScRsp>, IMessage, IEquatable<StartTimedCocoonStageScRsp>, IDeepCloneable<StartTimedCocoonStageScRsp>, IBufferMessage
	{
		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x00223013 File Offset: 0x00221213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTimedCocoonStageScRsp> Parser
		{
			get
			{
				return StartTimedCocoonStageScRsp._parser;
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600CBC3 RID: 52163 RVA: 0x0022301A File Offset: 0x0022121A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTimedCocoonStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x0022302C File Offset: 0x0022122C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTimedCocoonStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600CBC5 RID: 52165 RVA: 0x00223033 File Offset: 0x00221233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageScRsp()
		{
		}

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x0022303C File Offset: 0x0022123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageScRsp(StartTimedCocoonStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.cocoonId_ = other.cocoonId_;
			this.wave_ = other.wave_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x002230A0 File Offset: 0x002212A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTimedCocoonStageScRsp Clone()
		{
			return new StartTimedCocoonStageScRsp(this);
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600CBC8 RID: 52168 RVA: 0x002230A8 File Offset: 0x002212A8
		// (set) Token: 0x0600CBC9 RID: 52169 RVA: 0x002230B0 File Offset: 0x002212B0
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

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600CBCA RID: 52170 RVA: 0x002230B9 File Offset: 0x002212B9
		// (set) Token: 0x0600CBCB RID: 52171 RVA: 0x002230C1 File Offset: 0x002212C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CocoonId
		{
			get
			{
				return this.cocoonId_;
			}
			set
			{
				this.cocoonId_ = value;
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600CBCC RID: 52172 RVA: 0x002230CA File Offset: 0x002212CA
		// (set) Token: 0x0600CBCD RID: 52173 RVA: 0x002230D2 File Offset: 0x002212D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x002230DB File Offset: 0x002212DB
		// (set) Token: 0x0600CBCF RID: 52175 RVA: 0x002230E3 File Offset: 0x002212E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x002230EC File Offset: 0x002212EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTimedCocoonStageScRsp);
		}

		// Token: 0x0600CBD1 RID: 52177 RVA: 0x002230FC File Offset: 0x002212FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTimedCocoonStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CocoonId == other.CocoonId && this.Wave == other.Wave && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x0022316C File Offset: 0x0022136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CocoonId != 0U)
			{
				num ^= this.CocoonId.GetHashCode();
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x002231F3 File Offset: 0x002213F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x002231FB File Offset: 0x002213FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x00223204 File Offset: 0x00221404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CocoonId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CocoonId);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Wave);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x00223298 File Offset: 0x00221498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CocoonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CocoonId);
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x00223320 File Offset: 0x00221520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTimedCocoonStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CocoonId != 0U)
			{
				this.CocoonId = other.CocoonId;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x002233B0 File Offset: 0x002215B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x002233BC File Offset: 0x002215BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 88U)
				{
					if (num == 56U)
					{
						this.CocoonId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Wave = input.ReadUInt32();
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
					if (num == 114U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005234 RID: 21044
		private static readonly MessageParser<StartTimedCocoonStageScRsp> _parser = new MessageParser<StartTimedCocoonStageScRsp>(() => new StartTimedCocoonStageScRsp());

		// Token: 0x04005235 RID: 21045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005236 RID: 21046
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04005237 RID: 21047
		private uint retcode_;

		// Token: 0x04005238 RID: 21048
		public const int CocoonIdFieldNumber = 7;

		// Token: 0x04005239 RID: 21049
		private uint cocoonId_;

		// Token: 0x0400523A RID: 21050
		public const int WaveFieldNumber = 11;

		// Token: 0x0400523B RID: 21051
		private uint wave_;

		// Token: 0x0400523C RID: 21052
		public const int BattleInfoFieldNumber = 14;

		// Token: 0x0400523D RID: 21053
		private SceneBattleInfo battleInfo_;
	}
}
