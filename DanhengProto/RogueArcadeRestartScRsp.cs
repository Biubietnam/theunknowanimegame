using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E01 RID: 3585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeRestartScRsp : IMessage<RogueArcadeRestartScRsp>, IMessage, IEquatable<RogueArcadeRestartScRsp>, IDeepCloneable<RogueArcadeRestartScRsp>, IBufferMessage
	{
		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600A04A RID: 41034 RVA: 0x001AE19B File Offset: 0x001AC39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeRestartScRsp> Parser
		{
			get
			{
				return RogueArcadeRestartScRsp._parser;
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600A04B RID: 41035 RVA: 0x001AE1A2 File Offset: 0x001AC3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeRestartScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x001AE1B4 File Offset: 0x001AC3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeRestartScRsp.Descriptor;
			}
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x001AE1BB File Offset: 0x001AC3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartScRsp()
		{
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x001AE1C4 File Offset: 0x001AC3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartScRsp(RogueArcadeRestartScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x001AE210 File Offset: 0x001AC410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeRestartScRsp Clone()
		{
			return new RogueArcadeRestartScRsp(this);
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600A050 RID: 41040 RVA: 0x001AE218 File Offset: 0x001AC418
		// (set) Token: 0x0600A051 RID: 41041 RVA: 0x001AE220 File Offset: 0x001AC420
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

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x001AE229 File Offset: 0x001AC429
		// (set) Token: 0x0600A053 RID: 41043 RVA: 0x001AE231 File Offset: 0x001AC431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF RogueTournCurSceneInfo
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

		// Token: 0x0600A054 RID: 41044 RVA: 0x001AE23A File Offset: 0x001AC43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeRestartScRsp);
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x001AE248 File Offset: 0x001AC448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeRestartScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x001AE298 File Offset: 0x001AC498
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

		// Token: 0x0600A057 RID: 41047 RVA: 0x001AE2ED File Offset: 0x001AC4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x001AE2F5 File Offset: 0x001AC4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x001AE300 File Offset: 0x001AC500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(42);
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

		// Token: 0x0600A05A RID: 41050 RVA: 0x001AE35C File Offset: 0x001AC55C
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

		// Token: 0x0600A05B RID: 41051 RVA: 0x001AE3B4 File Offset: 0x001AC5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeRestartScRsp other)
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
					this.RogueTournCurSceneInfo = new IKENAAJDAFF();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x001AE41C File Offset: 0x001AC61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x001AE428 File Offset: 0x001AC628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
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
						this.RogueTournCurSceneInfo = new IKENAAJDAFF();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x040041AB RID: 16811
		private static readonly MessageParser<RogueArcadeRestartScRsp> _parser = new MessageParser<RogueArcadeRestartScRsp>(() => new RogueArcadeRestartScRsp());

		// Token: 0x040041AC RID: 16812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041AD RID: 16813
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040041AE RID: 16814
		private uint retcode_;

		// Token: 0x040041AF RID: 16815
		public const int RogueTournCurSceneInfoFieldNumber = 5;

		// Token: 0x040041B0 RID: 16816
		private IKENAAJDAFF rogueTournCurSceneInfo_;
	}
}
